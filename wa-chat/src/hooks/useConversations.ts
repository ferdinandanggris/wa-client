import { useState, useEffect, useRef, useCallback } from 'react'
import { getConversations, getPhoneNumberSummary, markAsRead } from '@/services/api'
import { wsClient } from '@/services/ws'
import type { Conversation, PhoneNumberSummary } from '@/types/chat'

export function useConversations(activePhoneId: string | null) {
  const [convs, setConvs] = useState<Conversation[]>([])
  const [phones, setPhones] = useState<PhoneNumberSummary[]>([])
  const [loading, setLoading] = useState(false)
  const [hasMore, setHasMore] = useState(true)
  const cursorRef = useRef<{ id?: string; updatedAt?: string }>({})
  const searchRef = useRef('')
  const filterRef = useRef<'all' | 'unread' | 'read'>('all')
  const typingRef = useRef<Record<string, { name: string }>>({})
  const [typingAgents, setTypingAgents] = useState<Record<string, { name: string }>>({})

  const load = useCallback(async (append = false) => {
    setLoading(true)
    try {
      const res = await getConversations({
        phone_number: activePhoneId || undefined,
        limit: 50,
        cursor_id: append ? cursorRef.current.id : undefined,
        cursor_updated_at: append ? cursorRef.current.updatedAt : undefined,
        search: searchRef.current || undefined,
        filter: filterRef.current !== 'all' ? filterRef.current : undefined,
      })
      setConvs(prev => append ? [...prev, ...res.items] : res.items)
      setHasMore(res.has_more)
      if (res.items.length > 0) {
        cursorRef.current = { id: res.next_cursor_id, updatedAt: res.next_cursor_updated_at }
      }
    } finally {
      setLoading(false)
    }
  }, [activePhoneId])

  const loadPhones = useCallback(async () => {
    try { setPhones(await getPhoneNumberSummary()) } catch { /* ignore */ }
  }, [])

  const setSearch = useCallback((s: string) => { searchRef.current = s; load(false) }, [load])
  const setFilter = useCallback((f: 'all' | 'unread' | 'read') => { filterRef.current = f; load(false) }, [load])
  const loadMore = useCallback(() => { if (hasMore && !loading) load(true) }, [hasMore, loading, load])

  const markRead = useCallback(async (id: string) => {
    try { await markAsRead(id) } catch { /* ignore */ }
    setConvs(prev => prev.map(c => c.id === id ? { ...c, unread_count: 0 } : c))
  }, [])

  const updateConvInList = useCallback((conv: Conversation) => {
    setConvs(prev => {
      const idx = prev.findIndex(c => c.id === conv.id)
      if (idx >= 0) {
        const next = [...prev]
        next[idx] = conv
        return next
      }
      return [conv, ...prev]
    })
  }, [])

  const removeConvFromList = useCallback((id: string) => {
    setConvs(prev => prev.filter(c => c.id !== id))
  }, [])

  useEffect(() => {
    load(false)
    loadPhones()
  }, [load, loadPhones])

  useEffect(() => {
    const unsub1 = wsClient.on('UpdateConversation', (payload: any) => {
      if (payload?.id) updateConvInList(payload as Conversation)
      loadPhones()
    })
    const unsub2 = wsClient.on('ReceiveMessage', () => load(false))
    const unsub3 = wsClient.on('AgentTyping', (payload: any) => {
      if (payload?.conversation_id && payload?.sender_name) {
        const id = String(payload.conversation_id)
        typingRef.current = { ...typingRef.current, [id]: { name: payload.sender_name } }
        setTypingAgents({ ...typingRef.current })
        setTimeout(() => {
          const { [id]: _, ...rest } = typingRef.current
          typingRef.current = rest
          setTypingAgents({ ...rest })
        }, 4000)
      }
    })
    return () => { unsub1(); unsub2(); unsub3() }
  }, [updateConvInList, loadPhones, load])

  return {
    conversations: convs, phones, loading, hasMore, typingAgents,
    loadMore, setSearch, setFilter, markRead, loadPhones, updateConvInList, removeConvFromList,
  }
}
