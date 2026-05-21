import axios from 'axios'
import type { ApiResponse, PagedResponse, Conversation, ChatMessage, PhoneNumberSummary } from '@/types/chat'

function getBaseUrl(): string {
  const params = new URLSearchParams(window.location.search)
  const ip = params.get('server_ip') || params.get('ip') || 'localhost'
  const port = params.get('server_port') || params.get('port') || '9090'
  return `http://${ip}:${port}/api`
}

const api = axios.create({ baseURL: getBaseUrl() })

export async function getPhoneNumberSummary(): Promise<PhoneNumberSummary[]> {
  const { data } = await api.get<ApiResponse<PhoneNumberSummary[]>>('/v1/phone-numbers/summary')
  return data.data ?? []
}

export async function getConversations(params: {
  phone_number?: string
  limit?: number
  cursor_id?: string
  cursor_updated_at?: string
  search?: string
  filter?: string
}): Promise<PagedResponse<Conversation>> {
  const { data } = await api.get<ApiResponse<PagedResponse<Conversation>>>('/v1/conversations', { params })
  return data.data ?? { items: [], limit: 50, has_more: false }
}

export async function getMessages(params: {
  conversation_id: string
  limit?: number
  cursor_id?: string
}): Promise<PagedResponse<ChatMessage>> {
  const { data } = await api.get<ApiResponse<PagedResponse<ChatMessage>>>(`/v1/conversations/${params.conversation_id}/messages`, {
    params: { limit: params.limit, cursor_id: params.cursor_id },
  })
  return data.data ?? { items: [], limit: 20, has_more: false }
}

export async function ensureConversation(payload: {
  phone_number: string
  customer_wa_id: string
  customer_name?: string
}): Promise<{ id: string; phone_number: string; customer_wa_id: string; customer_name: string; status: string }> {
  const { data } = await api.post<ApiResponse<any>>('/v1/conversations/ensure', payload)
  return data.data
}

export async function markAsRead(conversationId: string): Promise<void> {
  await api.post(`/v1/conversations/${conversationId}/read`)
}

export async function sendMessage(payload: {
  conversation_id: string
  message_type: string
  content?: string
  sender_name?: string
  media_url?: string
  media_id?: string
  template_name?: string
  language_code?: string
  body_params?: string[]
  header_params?: string[]
  button_params?: string[]
  reaction_emoji?: string
  reaction_to_message_id?: string
  context_message_id?: string
}): Promise<{ message_id: string; status: string }> {
  const { data } = await api.post<ApiResponse<{ message_id: string; status: string }>>('/v1/messages', payload)
  return data.data ?? { message_id: '', status: 'pending' }
}

export async function uploadMedia(file: File): Promise<{ media_id: string; file_path: string; file_type: string }> {
  const form = new FormData()
  form.append('file', file)
  const { data } = await api.post<ApiResponse<{ media_id: string; file_path: string; file_type: string }>>('/v1/media/upload', form)
  return data.data ?? { media_id: '', file_path: '', file_type: '' }
}

export async function updateConversationName(conversationId: string, name: string): Promise<void> {
  await api.patch(`/v1/conversations/${conversationId}/name`, { name })
}

export async function sendTypingIndicator(conversationId: string, senderName: string): Promise<void> {
  await api.post(`/v1/conversations/${conversationId}/typing`, { target: '', sender_name: senderName })
}

export async function getPingInfo(): Promise<any> {
  const { data } = await axios.get('/ping')
  return data
}
