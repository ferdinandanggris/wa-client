import { useState, useEffect, useRef, useCallback } from 'react'
import { wsClient, type WSStatus } from '@/services/ws'

export function useChatConnection() {
  const [status, setStatus] = useState<WSStatus>('disconnected')
  const cleanupRef = useRef<(() => void)[]>([])

  useEffect(() => {
    cleanupRef.current.push(wsClient.onStatusChange(setStatus))
    return () => { cleanupRef.current.forEach(fn => fn()); cleanupRef.current = [] }
  }, [])

  const connect = useCallback((companyId = 'default') => wsClient.connect(companyId), [])
  const disconnect = useCallback(() => wsClient.disconnect(), [])
  const retry = useCallback(() => { wsClient.disconnect(); wsClient.connect('default') }, [])

  return { status, connect, disconnect, retry }
}
