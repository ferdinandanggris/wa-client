import { useState, useEffect, useRef, useCallback, useMemo } from 'react'
import { getMessages } from '@/services/api'
import { wsClient } from '@/services/ws'
import type { ChatMessage } from '@/types/chat'

export function useMessages(conversationId: string | null, onUnreadReset?: (id: string) => void) {
  const [msgs, setMsgs] = useState<ChatMessage[]>([])
  const [loading, setLoading] = useState(false)
  const [hasMore, setHasMore] = useState(true)
  const cursorRef = useRef<number | undefined>(undefined)
  const prevConvRef = useRef<string | null>(null)

  const load = useCallback(async (append = false) => {
    if (!conversationId) { setMsgs([]); return }
    setLoading(true)
    try {
      const res = await getMessages({
        conversation_id: conversationId,
        limit: 50,
        cursor_id: append ? String(cursorRef.current ?? 0) : undefined,
      })
      setMsgs(prev => append ? [...res.items, ...prev] : res.items)
      setHasMore(res.has_more)
      if (res.items.length > 0) {
        cursorRef.current = res.next_cursor_id ? parseInt(res.next_cursor_id) : res.items.length
      }
    } finally { setLoading(false) }
  }, [conversationId])

  const loadMore = useCallback(() => {
    if (hasMore && !loading && conversationId) load(true)
  }, [hasMore, loading, load, conversationId])

  useEffect(() => {
    if (conversationId && conversationId !== prevConvRef.current) {
      cursorRef.current = undefined
      setHasMore(true)
      load(false)
      onUnreadReset?.(conversationId)
      prevConvRef.current = conversationId
    }
  }, [conversationId, load, onUnreadReset])

  useEffect(() => {
    if (!conversationId) return
    const unsub1 = wsClient.on('ReceiveMessage', (payload: any) => {
      if (payload?.conversation_id === conversationId) {
        setMsgs(prev => [...prev, normalizeMsg(payload)])
      }
    })
    const unsub2 = wsClient.on('MessageStatusUpdated', (payload: any) => {
      const msgId = payload?.wa_message_id ?? payload?.message_id
      const status = payload?.status
      if (msgId && status) {
        setMsgs(prev => prev.map(m =>
          m.message_id === msgId || m.id === msgId ? { ...m, status } : m
        ))
      }
    })
    const unsub3 = wsClient.on('MessageStatusFailed', (payload: any) => {
      const msgId = payload?.wa_message_id ?? payload?.message_id
      if (msgId) {
        setMsgs(prev => prev.map(m =>
          m.message_id === msgId || m.id === msgId
            ? { ...m, status: 'failed', error_message: payload?.raw_payload?.error?.message ?? 'Unknown error' }
            : m
        ))
      }
    })
    return () => { unsub1(); unsub2(); unsub3() }
  }, [conversationId])

  const reactions = useMemo(() => {
    const map = new Map<string, { emojis: string[]; total: number }>()
    msgs.filter(m => m.message_type === 'reaction').forEach(r => {
      const targetId = r.message_text || r.content || ''
      const existing = map.get(targetId)
      if (existing) {
        existing.emojis.push(r.content || r.message_text || '')
        existing.total++
      } else {
        map.set(targetId, { emojis: [r.content || r.message_text || ''], total: 1 })
      }
    })
    return map
  }, [msgs])

  const addMessage = useCallback((msg: ChatMessage) => {
    setMsgs(prev => [...prev, normalizeMsg(msg)])
  }, [])

  return { messages: msgs, loading, hasMore, loadMore, reactions, addMessage, load }
}

function normalizeMsg(p: any): ChatMessage {
  return {
    id: p.id || p.message_id || '',
    message_id: p.message_id || p.id || '',
    conversation_id: p.conversation_id,
    sender_name: p.sender_name || '',
    message_text: p.content || p.message_text || '',
    content: p.content || '',
    message_type: p.message_type || 'text',
    direction: (p.direction || 'INBOUND').toUpperCase(),
    status: p.status || 'pending',
    media_url: p.media_url,
    template_id: p.template_id,
    file_path: p.file_path,
    file_type: p.file_type,
    file_name: p.file_name,
    created_at: p.created_at || new Date().toISOString(),
    message_timestamp: p.message_timestamp || p.sent_at ? Math.floor(new Date(p.sent_at || p.created_at).getTime() / 1000) : undefined,
    reactionData: p.reactionData || null,
    error_message: p.error_message,
  }
}

function onUnreadReset(_id: string) {}
