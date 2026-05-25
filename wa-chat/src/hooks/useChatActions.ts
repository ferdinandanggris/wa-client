import { useCallback, useRef } from 'react'
import { sendMessage, uploadMedia, ensureConversation, sendTypingIndicator } from '@/services/api'
import type { ChatMessage } from '@/types/chat'

export function useChatActions(
  activeConversation: { id: string; customer_wa_id: string; display_number?: string } | null,
  onMessageSent?: (msg: ChatMessage) => void,
  onMessageUpdated?: (tempId: string, serverId: string) => void,
  onConversationCreated?: (id: string) => void,
) {
  const typingTimer = useRef<ReturnType<typeof setTimeout> | undefined>(undefined)

  const handleSend = useCallback(async (text: string, replyingTo?: ChatMessage | null) => {
    if (!activeConversation) return
    const msg: ChatMessage = {
      id: `temp-${Date.now()}`,
      message_id: '',
      message_text: text,
      message_type: 'text',
      direction: 'OUTBOUND',
      status: 'pending',
      created_at: new Date().toISOString(),
      sender_name: 'CS Agent',
      reply_name: replyingTo ? (replyingTo.sender_name || 'Customer') : undefined,
      reply_text: replyingTo ? (replyingTo.message_text || replyingTo.content || '') : undefined,
      context_message_id: replyingTo?.id || undefined,
    }
    onMessageSent?.(msg)
    try {
      const result = await sendMessage({
        conversation_id: activeConversation.id,
        message_type: 'text',
        content: text,
        sender_name: 'CS Agent',
        context_message_id: replyingTo?.id || undefined,
      })
      if (result?.message_id) onMessageUpdated?.(msg.id, result.message_id)
    } catch { /* handle error */ }
  }, [activeConversation, onMessageSent, onMessageUpdated])

  const handleSendMedia = useCallback(async (file: File) => {
    if (!activeConversation) return
    try {
      const { media_id, file_path, file_type } = await uploadMedia(file)
      await sendMessage({
        conversation_id: activeConversation.id,
        message_type: file_type.startsWith('image/') ? 'image' : 'document',
        media_url: file_path,
        media_id,
        sender_name: 'CS Agent',
      })
    } catch { /* handle error */ }
  }, [activeConversation])

  const handleSendTemplate = useCallback(async (templateName: string, lang: string, bodyParams: string[]) => {
    if (!activeConversation) return
    try {
      await sendMessage({
        conversation_id: activeConversation.id,
        message_type: 'template',
        template_name: templateName,
        language_code: lang,
        body_params: bodyParams,
        sender_name: 'CS Agent',
      })
    } catch { /* handle error */ }
  }, [activeConversation])

  const handleSendReaction = useCallback(async (emoji: string, toMsgId: string) => {
    if (!activeConversation) return
    try {
      await sendMessage({
        conversation_id: activeConversation.id,
        message_type: 'reaction',
        reaction_emoji: emoji,
        reaction_to_message_id: toMsgId,
        content: emoji,
        sender_name: 'CS Agent',
      })
    } catch { /* handle error */ }
  }, [activeConversation])

  const handleEnsureConv = useCallback(async (phone_number: string, customer_wa_id: string, customer_name?: string) => {
    const conv = await ensureConversation({ phone_number, customer_wa_id, customer_name })
    onConversationCreated?.(conv.id)
    return conv
  }, [onConversationCreated])

  const sendTyping = useCallback(() => {
    if (!activeConversation) return
    if (typingTimer.current) clearTimeout(typingTimer.current)
    typingTimer.current = setTimeout(() => {
      sendTypingIndicator(activeConversation.id, 'CS Agent')
    }, 1000)
  }, [activeConversation])

  return { handleSend, handleSendMedia, handleSendTemplate, handleSendReaction, handleEnsureConv, sendTyping }
}
