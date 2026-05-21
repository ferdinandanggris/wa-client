import React from 'react';
import { RefreshCw, Home } from "lucide-react";
import { Button } from "@/components/ui/button";
import { Separator } from "@/components/ui/separator";
import { Avatar, AvatarFallback } from "@/components/ui/avatar";
import type { PhoneNumberSummary } from '@/types/chat';
import { getInitials } from '@/lib/chatUtils';

interface Props {
  phones: PhoneNumberSummary[];
  totalUnread: number;
  activePhoneId: string | null;
  setActivePhoneId: (id: string | null) => void;
  onRefresh: () => void;
}

const ChatSidebar: React.FC<Props> = ({ phones, totalUnread, activePhoneId, setActivePhoneId, onRefresh }) => {
  return (
    <div className="w-[70px] flex-shrink-0 bg-[#f0f2f5] border-r flex flex-col items-center py-4 gap-4 z-30">
      <div className="relative group">
        <Button variant="ghost" size="icon"
          className={`w-12 h-12 rounded-xl transition-all duration-200 ${activePhoneId === null ? 'bg-[#00a884] text-white rounded-lg' : 'bg-white text-slate-600 hover:bg-[#00a884] hover:text-white'}`}
          onClick={() => setActivePhoneId(null)} title="Semua Nomor">
          <Home className="w-6 h-6" />
        </Button>
        {totalUnread > 0 && <span className="absolute -top-1 -right-1 bg-red-500 text-white text-[10px] font-bold px-1.5 py-0.5 rounded-full border-2 border-slate-100 shadow-sm">{totalUnread > 99 ? '99+' : totalUnread}</span>}
        {activePhoneId === null && <div className="absolute left-[-15px] top-1/2 -translate-y-1/2 w-1 h-8 bg-[#00a884] rounded-r-full" />}
      </div>
      <Separator className="w-10 bg-slate-200" />
      {phones.map(p => (
        <div key={p.id} className="relative group">
          <Button variant="ghost" size="icon"
            className={`w-12 h-12 rounded-xl transition-all duration-200 ${activePhoneId === p.phone_number ? 'bg-[#00a884] text-white rounded-lg' : 'bg-white text-slate-600 hover:bg-[#00a884] hover:text-white'}`}
            onClick={() => setActivePhoneId(activePhoneId === p.phone_number ? null : p.phone_number)}
            title={`${p.verified_name || p.phone_number}${!p.is_active ? ' (inactive)' : ''}`}>
            <span className="text-sm font-bold">{getInitials(p.display_name || p.phone_number)}</span>
          </Button>
          <div className={`absolute bottom-0.5 right-0.5 w-3 h-3 rounded-full border-2 border-[#f0f2f5] ${p.is_active ? 'bg-green-500' : 'bg-gray-400'}`} />
          {p.unread_count > 0 && <div className="absolute -top-1 -right-1 bg-red-500 text-white text-[10px] rounded-full px-1.5 h-5 flex items-center justify-center font-bold border-2 border-[#f0f2f5] shadow-sm">{p.unread_count > 99 ? '99+' : p.unread_count}</div>}
          {activePhoneId === p.phone_number && <div className="absolute left-[-15px] top-1/2 -translate-y-1/2 w-1 h-8 bg-[#00a884] rounded-r-full" />}
        </div>
      ))}
      <div className="mt-auto flex flex-col items-center gap-4 mb-4">
        <Button variant="ghost" size="icon" className="rounded-full hover:bg-slate-200" onClick={onRefresh} title="Refresh Data"><RefreshCw className="h-4 w-4" /></Button>
        <Separator className="w-10 bg-slate-200" />
        <div className="relative group">
          <Avatar className="h-10 w-10 border-2 border-white shadow-md"><AvatarFallback className="bg-[#00a884] text-white font-bold text-xs">CS</AvatarFallback></Avatar>
          <div className="absolute left-14 top-1/2 -translate-y-1/2 bg-white px-3 py-1.5 rounded-lg shadow-xl border border-slate-100 opacity-0 group-hover:opacity-100 transition-opacity pointer-events-none whitespace-nowrap z-50">
            <p className="text-xs font-bold text-slate-800">CS Agent</p>
            <p className="text-[10px] text-slate-500">cs@default.com</p>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ChatSidebar;
