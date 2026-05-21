export interface ApiResponse<T> {
  status_code?: number
  status?: boolean
  ok?: boolean
  message?: string
  data: T
}

export interface PagedResponse<T> {
  items: T[]
  limit: number
  next_cursor_updated_at?: string
  next_cursor_id?: string
  has_more: boolean
}

export interface Conversation {
  id: string
  customer_wa_id: string
  customer_name: string
  display_number?: string
  verified_name: string
  wa_channel_id?: string
  waba_id?: string
  last_message_preview: string
  unread_count: number
  status: string
  is_template_required: boolean
  updated_at: string
  last_message_timestamp?: number
}

export interface ChatMessage {
  id: string
  message_id: string
  conversation_id?: string
  sender_name?: string
  message_text?: string
  content?: string
  message_type: string
  direction: 'INBOUND' | 'OUTBOUND'
  status: string
  media_url?: string
  template_id?: string
  template_params?: string
  file_path?: string
  file_type?: string
  file_name?: string
  media_id?: string
  created_at: string
  message_timestamp?: number
  reply_name?: string
  reply_text?: string
  reactions?: string[]
  reactionData?: { emojis: string[]; total: number } | null
  error_details?: { code: number; message_local: string; message_original: string; failed_at: string }
  wa_status?: string
  error_message?: string
}

export interface PhoneNumberSummary {
  id: string
  phone_number: string
  display_name: string
  verified_name: string
  is_active: boolean
  about: string
  profile_picture_url: string
  unread_count: number
}
