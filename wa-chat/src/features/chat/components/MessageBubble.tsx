import React from 'react';
import { Check, CheckCheck, AlertCircle, Clock, Reply, Smile, Info, RotateCw } from "lucide-react";
import { Avatar, AvatarFallback } from "@/components/ui/avatar";
import { Button } from "@/components/ui/button";
import type { ChatMessage } from '@/types/chat';
import { formatTime, formatDividerDate, isSameDay, getInitials } from '@/lib/chatUtils';
import { cn } from '@/lib/utils';

interface Props {
  msg: ChatMessage;
  prevMsg?: ChatMessage;
  onReply: (msg: ChatMessage) => void;
  onReaction: (msg: ChatMessage) => void;
  onResend: (msg: ChatMessage) => void;
  conversationName?: string;
}

const MessageBubble: React.FC<Props> = ({ msg, prevMsg, onReply, onReaction, onResend, conversationName }) => {
  const isOutbound = msg.direction?.toUpperCase() === 'OUTBOUND';
  const isFailed = msg.status === 'failed';
  const ts = msg.message_timestamp ? msg.message_timestamp * 1000 : msg.created_at ? new Date(msg.created_at).getTime() : Date.now();
  const showDateDivider = !prevMsg || !isSameDay(new Date(ts), new Date(
    (prevMsg.message_timestamp ? prevMsg.message_timestamp * 1000 : prevMsg.created_at ? new Date(prevMsg.created_at).getTime() : Date.now())
  ));

  const renderStatusIcon = (status?: string) => {
    switch (status?.toLowerCase()) {
      case 'pending': return <Clock className="w-3 h-3 text-slate-100" />;
      case 'sent': return <Check className="w-3 h-3 text-slate-100" />;
      case 'delivered': return <CheckCheck className="w-3 h-3 text-slate-100" />;
      case 'read': return <CheckCheck className="w-3 h-3 text-blue-500" />;
      case 'failed': return <AlertCircle className="w-3 h-3 text-red-500" />;
      default: return null;
    }
  };

  return (
    <div className="flex flex-col mb-1 group/bubble">
      {showDateDivider && (
        <div className="flex justify-center my-6 sticky top-2 z-10">
          <span className="bg-slate-100/80 backdrop-blur-sm text-slate-500 text-[10px] uppercase tracking-wider font-bold px-3 py-1 rounded-full shadow-sm border border-slate-200/50">{formatDividerDate(msg.created_at, msg.message_timestamp)}</span>
        </div>
      )}
      <div className={cn("flex group relative px-4 py-0.5", isOutbound ? "justify-end" : "justify-start")}>
        {!isOutbound && (
          <Avatar className="w-8 h-8 mr-2 mt-1 shrink-0 shadow-sm border-2 border-white"><AvatarFallback className="bg-slate-200 text-slate-600 text-[10px] font-bold uppercase">{getInitials(conversationName || 'C')}</AvatarFallback></Avatar>
        )}
        <div className={cn("relative max-w-[85%] transition-all", isOutbound ? "items-end" : "items-start")}>
          <div className={cn("rounded-2xl px-4 py-2 shadow-sm border min-w-[80px]", isOutbound ? "bg-[#00a884] text-white border-r rounded-tr-none" : "bg-white text-slate-800 border-slate-200 rounded-tl-none")}>
            <div className={cn("text-[10px] font-bold mb-1 flex items-center gap-1.5", isOutbound ? "text-slate-200" : "text-[#00a884]")}>
              {isOutbound ? msg.sender_name || 'CS Agent' : conversationName}
            </div>
            {msg.message_type === 'template' ? (
              <div className="text-sm"><span className="italic opacity-80">🔷 Template message</span><p className="mt-1">{msg.message_text || msg.content}</p></div>
            ) : msg.message_type === 'image' ? (
              <div className="flex flex-col gap-1">
                {msg.media_url ? <img src={msg.media_url} alt="media" className="w-48 h-36 object-cover rounded-lg" /> : <div className="w-48 h-36 bg-slate-200 rounded-lg flex items-center justify-center text-slate-400 text-xs">📷 Image</div>}
                <p className="text-sm mt-1">{msg.message_text || msg.content}</p>
              </div>
            ) : (
              <p className="text-sm whitespace-pre-wrap break-words">{msg.message_text || msg.content}</p>
            )}
            <div className={cn("flex items-center gap-1.5 mt-1", isOutbound ? "justify-end" : "justify-start")}>
              <span className={cn("text-[9px] font-medium tracking-tight opacity-70", isOutbound ? "text-indigo-100" : "text-slate-400")}>{formatTime(msg.created_at, msg.message_timestamp)}</span>
              {isOutbound && renderStatusIcon(msg.status)}
            </div>
          </div>
          {msg.reactionData && (
            <div className={cn("absolute -bottom-2 flex items-center bg-white border border-slate-100 rounded-full px-1.5 py-0.5 shadow-md scale-90 origin-center transition-transform hover:scale-100 select-none z-20", isOutbound ? "right-2" : "left-2")}>
              <div className="flex -space-x-1 hover:space-x-0.5 transition-all">{msg.reactionData.emojis.map((emoji, idx) => <span key={idx} className="text-[12px] drop-shadow-sm transition-transform active:scale-125 hover:z-10">{emoji}</span>)}</div>
              {msg.reactionData.total > 1 && <span className="ml-1 text-[9px] font-bold text-slate-500 border-l pl-1 border-slate-100">{msg.reactionData.total}</span>}
            </div>
          )}
          <div className={cn("absolute top-0 opacity-0 group-hover/bubble:opacity-100 transition-all duration-200 flex items-center gap-1 px-2 pointer-events-none group-hover/bubble:pointer-events-auto", isOutbound ? "right-full mr-2 flex-row-reverse" : "left-full ml-2")}>
            {!isFailed ? (
              <>
                <Button variant="ghost" size="icon" className="w-7 h-7 rounded-full bg-white/80 backdrop-blur-sm shadow-sm border border-slate-200 hover:bg-slate-50" onClick={() => onReply(msg)} title="Balas"><Reply className="w-3.5 h-3.5 text-slate-500" /></Button>
                <Button variant="ghost" size="icon" className="w-7 h-7 rounded-full bg-white/80 backdrop-blur-sm shadow-sm border border-slate-200 hover:bg-slate-50" onClick={() => onReaction(msg)} title="Reaksi"><Smile className="w-3.5 h-3.5 text-slate-500" /></Button>
              </>
            ) : (
              <>
                <Button variant="ghost" size="icon" className="w-7 h-7 rounded-full bg-white/80 backdrop-blur-sm shadow-sm border border-slate-200" title="Info Gagal"><Info className="w-3.5 h-3.5 text-slate-500" /></Button>
                <Button variant="ghost" size="icon" className="w-7 h-7 rounded-full bg-white/80 backdrop-blur-sm shadow-sm border border-slate-200 hover:bg-slate-50" onClick={() => onResend(msg)} title="Kirim Ulang"><RotateCw className="w-3.5 h-3.5 text-slate-500" /></Button>
              </>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default MessageBubble;
