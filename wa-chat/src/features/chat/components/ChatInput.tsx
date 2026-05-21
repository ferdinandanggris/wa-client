import React, { useRef, useEffect } from 'react';
import { Smile, Paperclip, LayoutGrid, Send, X, Reply } from "lucide-react";
import { Button } from "@/components/ui/button";
import type { ChatMessage } from '@/types/chat';
import { cn } from '@/lib/utils';

interface Props {
  inputText: string;
  setInputText: (text: string) => void;
  handleSend: () => void;
  handleKeyDown: (e: React.KeyboardEvent) => void;
  replyingTo: ChatMessage | null;
  setReplyingTo: (msg: ChatMessage | null) => void;
  isTemplateRequired?: boolean;
  onFileSelect?: (file: File) => void;
  onTemplateSelect?: () => void;
}

const ChatInput: React.FC<Props> = ({ inputText, setInputText, handleSend, handleKeyDown, replyingTo, setReplyingTo, isTemplateRequired, onFileSelect, onTemplateSelect }) => {
  const textareaRef = useRef<HTMLTextAreaElement>(null);
  const fileRef = useRef<HTMLInputElement>(null);

  useEffect(() => {
    if (textareaRef.current) {
      textareaRef.current.style.height = 'auto';
      textareaRef.current.style.height = `${Math.min(textareaRef.current.scrollHeight, 128)}px`;
    }
  }, [inputText]);

  const handlePaste = (e: React.ClipboardEvent) => {
    const files = e.clipboardData.files;
    if (files.length > 0 && onFileSelect) {
      e.preventDefault();
      onFileSelect(files[0]);
    }
  };

  const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const file = e.target.files?.[0];
    if (file && onFileSelect) onFileSelect(file);
    if (fileRef.current) fileRef.current.value = '';
  };

  return (
    <div className="p-4 bg-white border-t border-slate-100 flex flex-col gap-2">
      <input ref={fileRef} type="file" className="hidden" onChange={handleFileChange} />
      {replyingTo && (
        <div className="flex items-center justify-between p-2 pl-3 bg-slate-50/80 rounded-xl border border-slate-100 border-l-4 border-l-indigo-500 animate-in slide-in-from-bottom-2 duration-200">
          <div className="flex items-center gap-3 overflow-hidden">
            <Reply className="w-4 h-4 text-indigo-500 shrink-0" />
            <div className="flex flex-col min-w-0">
              <span className="text-[10px] font-bold text-indigo-600 uppercase tracking-wider">Balas ke {replyingTo.sender_name || 'pesan'}</span>
              <p className="text-xs text-slate-500 truncate">{replyingTo.message_text || replyingTo.content || (replyingTo.message_type === 'image' ? '📷 Foto' : 'Media')}</p>
            </div>
          </div>
          <Button variant="ghost" size="icon" className="h-6 w-6 rounded-full hover:bg-slate-200 transition-colors" onClick={() => setReplyingTo(null)}><X className="w-3 h-3 text-slate-400" /></Button>
        </div>
      )}
      <div className="flex items-end gap-3">
        <div className="flex items-center gap-1 mb-1">
          <Button variant="ghost" size="icon" className={cn("rounded-xl h-10 w-10 hover:bg-slate-100 transition-colors", isTemplateRequired && "opacity-50 pointer-events-none")}
            onClick={() => fileRef.current?.click()} title="Lampirkan File"><Paperclip className="w-5 h-5 text-slate-500" /></Button>
          <Button variant="ghost" size="icon" className={cn("rounded-xl h-10 w-10 hover:bg-slate-100 transition-colors", isTemplateRequired && "opacity-50 pointer-events-none")} title="Emoji"><Smile className="w-5 h-5 text-slate-500" /></Button>
          {!replyingTo && <Button variant="ghost" size="icon" className="rounded-xl h-10 w-10 hover:bg-slate-100 transition-colors" onClick={onTemplateSelect} title="Template WhatsApp"><LayoutGrid className="w-5 h-5 text-[#00a884]" /></Button>}
        </div>
        <div className="flex-1 relative">
          <textarea ref={textareaRef} rows={1} placeholder={isTemplateRequired ? "Sesi berakhir. Kirim template untuk memulai..." : "Ketik pesan..."}
            className={cn("w-full bg-slate-50 rounded-2xl px-4 py-2.5 text-sm ring-1 ring-slate-200 focus:ring-2 focus:ring-[#00a884] focus:bg-white resize-none max-h-[128px] transition-all scrollbar-thin outline-none", isTemplateRequired && "opacity-70")}
            value={inputText} onChange={(e) => setInputText(e.target.value)} onKeyDown={handleKeyDown} onPaste={handlePaste} readOnly={isTemplateRequired}
          />
        </div>
        <Button size="icon" className={cn("rounded-xl h-10 w-10 transition-all mb-1", inputText.trim() ? "bg-[#00a884]/80 hover:bg-[#00a884] shadow-md shadow-[#00a884]/60 scale-100" : "bg-slate-100 text-slate-400 hover:bg-slate-200 scale-95", isTemplateRequired && "opacity-50 pointer-events-none")}
          onClick={handleSend} disabled={!inputText.trim() || isTemplateRequired}>
          <Send className={cn("w-5 h-5", inputText.trim() ? "translate-x-0.5" : "")} style={inputText.trim() ? { marginLeft: "-.4em" } : {}} />
        </Button>
      </div>
    </div>
  );
};

export default ChatInput;
