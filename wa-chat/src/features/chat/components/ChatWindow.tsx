import React, { useRef, useEffect, useState } from 'react';
import { Search } from "lucide-react";
import { Avatar, AvatarFallback } from "@/components/ui/avatar";
import { Button } from "@/components/ui/button";
import { ScrollArea } from "@/components/ui/scroll-area";
import type { Conversation, ChatMessage } from '@/types/chat';
import MessageBubble from './MessageBubble';
import ChatInput from './ChatInput';
import { cn } from '@/lib/utils';
import { getInitials } from '@/lib/chatUtils';

interface Props {
  activeConversation: Conversation | null;
  messages: ChatMessage[];
  typingAgents: Record<string, { name: string }>;
  loading: boolean;
  hasMore: boolean;
  onLoadMore: () => void;
  onSend: (text: string, replyingTo?: ChatMessage | null) => void;
  onSendMedia: (file: File) => void;
  onReaction: (emoji: string, msgId: string) => void;
  onTemplateSelect?: () => void;
  replyingTo: ChatMessage | null;
  setReplyingTo: (msg: ChatMessage | null) => void;
}

const ChatWindow: React.FC<Props> = ({ activeConversation, messages, typingAgents, loading, hasMore, onLoadMore, onSend, onSendMedia, onReaction, onTemplateSelect, replyingTo, setReplyingTo }) => {
  const [inputText, setInputText] = useState('');
  const scrollRef = useRef<HTMLDivElement>(null);

  useEffect(() => {
    if (scrollRef.current) {
      const viewport = scrollRef.current.querySelector('[data-radix-scroll-area-viewport]') as HTMLDivElement;
      if (viewport) viewport.scrollTop = viewport.scrollHeight;
    }
  }, [messages, activeConversation?.id]);

  if (!activeConversation) {
    return (
      <div className="flex-1 flex flex-col items-center justify-center bg-slate-50/30">
        <div className="text-center space-y-4">
          <div className="w-24 h-24 bg-[#00a884]/10 rounded-full flex items-center justify-center mx-auto mb-6 shadow-sm border border-indigo-100">
            <Avatar className="w-16 h-16 rounded-full"><AvatarFallback className="bg-white text-[#00a884] font-bold text-2xl">WC</AvatarFallback></Avatar>
          </div>
          <h2 className="text-2xl font-bold text-slate-800">Whatsapp Client</h2>
          <p className="text-slate-500 max-w-sm mx-auto text-sm leading-relaxed">Pilih percakapan dari daftar di sebelah kiri untuk mulai berkirim pesan dengan pelanggan Anda secara real-time.</p>
        </div>
      </div>
    );
  }

  const currentTyping = typingAgents[activeConversation.id];

  const handleKeyDown = (e: React.KeyboardEvent) => {
    if (e.key === 'Enter' && !e.shiftKey) {
      e.preventDefault()
      if (inputText.trim()) {
        onSend(inputText.trim(), replyingTo)
        setInputText('')
        setReplyingTo(null)
      }
    }
  }

  return (
    <div className="flex-1 flex flex-col min-w-0 bg-white" style={{ backgroundImage: "url('https://user-images.githubusercontent.com/15075759/28719144-86dc0f70-73b1-11e7-911d-60d70fcded21.png')" }}>
      <div className="h-[72px] border-b border-slate-100 flex items-center justify-between px-6 bg-white/80 backdrop-blur-md sticky top-0 z-20 shadow-sm">
        <div className="flex items-center gap-3 min-w-0">
          <Avatar className="w-10 h-10 border-2 border-white shadow-sm ring-1 ring-slate-100"><AvatarFallback className="bg-slate-100 text-slate-600 font-bold">{getInitials(activeConversation.customer_name || activeConversation.customer_wa_id)}</AvatarFallback></Avatar>
          <div className="min-w-0">
            <h2 className="text-sm font-bold text-slate-900 truncate">{activeConversation.customer_name || activeConversation.customer_wa_id || 'Unknown'}</h2>
            <div className="flex items-center gap-2">
              <div className={cn("w-2 h-2 rounded-full", currentTyping ? "bg-green-500 animate-pulse" : "bg-slate-200")} />
              <span className={cn("text-[11px] font-medium transition-colors", currentTyping ? "text-green-600 italic" : "text-slate-500")}>{currentTyping ? `${currentTyping.name} sedang mengetik...` : activeConversation.customer_wa_id}</span>
            </div>
          </div>
        </div>
        <div className="flex items-center gap-1.5">
          <Button variant="ghost" size="icon" className="rounded-full h-9 w-9 text-slate-500 hover:bg-slate-50"><Search className="w-4 h-4" /></Button>
        </div>
      </div>

      <div className="flex-1 relative overflow-hidden bg-slate-50/30">
        <ScrollArea className="h-full w-full [&>div>div]:!block" ref={scrollRef}>
          <div className="flex flex-col py-4 w-full min-w-0">
            {hasMore && !loading && (
              <div className="flex justify-center py-2">
                <Button variant="ghost" size="sm" className="text-xs text-slate-500" onClick={onLoadMore}>Muat pesan lama</Button>
              </div>
            )}
            {loading && <div className="p-4 text-center text-gray-400 text-sm">Loading...</div>}
            {messages.map((msg, idx) => (
              <MessageBubble key={msg.id || msg.message_id} msg={msg} prevMsg={idx > 0 ? messages[idx - 1] : undefined}
                onReply={(m) => setReplyingTo(m)} onReaction={(m) => onReaction('👍', m.message_id)} onResend={() => {}}
                conversationName={activeConversation.customer_name}
              />
            ))}
          </div>
        </ScrollArea>

        {activeConversation.is_template_required && (
          <div className="absolute inset-x-0 bottom-6 flex justify-center z-30 animate-in slide-in-from-bottom-4 duration-500">
            <div className="bg-white/90 backdrop-blur-md border border-indigo-100 shadow-2xl rounded-2xl p-5 flex flex-col items-center gap-4 max-w-sm ring-1 ring-indigo-50/50">
              <div className="w-12 h-12 bg-indigo-50 rounded-full flex items-center justify-center"><svg className="w-6 h-6 text-[#00a884]" fill="none" viewBox="0 0 24 24" stroke="currentColor"><path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M12 8v4l3 3m6-3a9 9 0 11-18 0 9 9 0 0118 0z" /></svg></div>
              <div className="text-center">
                <h3 className="text-sm font-bold text-slate-900 mb-1">Jendela Melayani Berakhir</h3>
                <p className="text-[11px] text-slate-500 leading-relaxed px-4">Batas waktu Respons telah habis. Gunakan template pesan untuk memulai kembali percakapan ini.</p>
              </div>
              <Button size="sm" className="bg-[#00a884]/80 hover:bg-[#00a884] shadow-lg shadow-indigo-100 rounded-xl text-xs h-9 gap-2" onClick={onTemplateSelect}>Pilih Template</Button>
            </div>
          </div>
        )}
      </div>

      <ChatInput inputText={inputText} setInputText={setInputText}
        handleSend={() => { if (inputText.trim()) { onSend(inputText.trim(), replyingTo); setInputText(''); setReplyingTo(null) } }}
        handleKeyDown={handleKeyDown}
        replyingTo={replyingTo} setReplyingTo={setReplyingTo}
        isTemplateRequired={activeConversation.is_template_required}
        onFileSelect={onSendMedia}
        onTemplateSelect={onTemplateSelect}
      />
    </div>
  );
};

export default ChatWindow;
