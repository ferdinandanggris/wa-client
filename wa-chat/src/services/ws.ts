export type WSStatus = 'connecting' | 'connected' | 'reconnecting' | 'disconnected'

type EventHandler = (payload: any) => void

export class WSChatClient {
  private ws: WebSocket | null = null
  private status: WSStatus = 'disconnected'
  private handlers = new Map<string, Set<EventHandler>>()
  private companyId = ''
  private reconnectTimer: ReturnType<typeof setTimeout> | null = null
  private statusListeners = new Set<(s: WSStatus) => void>()

  connect(companyId: string) {
    if (this.ws?.readyState === WebSocket.OPEN) return
    this.companyId = companyId
    this.setStatus('connecting')

    const params = new URLSearchParams(window.location.search)
    const ip = params.get('server_ip') || params.get('ip') || 'localhost'
    const port = params.get('server_port') || params.get('port') || '9090'
    const url = `ws://${ip}:${port}/ws?company_id=${companyId}`

    this.ws = new WebSocket(url)
    this.ws.onopen = () => this.setStatus('connected')
    this.ws.onclose = () => {
      this.setStatus('disconnected')
      this.scheduleReconnect()
    }
    this.ws.onerror = () => {
      this.setStatus('disconnected')
      this.scheduleReconnect()
    }
    this.ws.onmessage = (ev) => {
      try {
        const msg = JSON.parse(ev.data)
        const hs = this.handlers.get(msg.type)
        if (hs) hs.forEach(fn => fn(msg.payload))
      } catch { /* ignore parse errors */ }
    }
  }

  private scheduleReconnect() {
    if (this.reconnectTimer) return
    this.setStatus('reconnecting')
    this.reconnectTimer = setTimeout(() => {
      this.reconnectTimer = null
      if (this.companyId) this.connect(this.companyId)
    }, 3000)
  }

  disconnect() {
    if (this.reconnectTimer) { clearTimeout(this.reconnectTimer); this.reconnectTimer = null }
    this.ws?.close()
    this.ws = null
    this.setStatus('disconnected')
  }

  on(event: string, handler: EventHandler) {
    if (!this.handlers.has(event)) this.handlers.set(event, new Set())
    this.handlers.get(event)!.add(handler)
    return () => this.handlers.get(event)?.delete(handler)
  }

  onStatusChange(fn: (s: WSStatus) => void) {
    this.statusListeners.add(fn)
    return () => this.statusListeners.delete(fn)
  }

  getStatus() { return this.status }

  private setStatus(s: WSStatus) {
    this.status = s
    this.statusListeners.forEach(fn => fn(s))
  }
}

export const wsClient = new WSChatClient()
