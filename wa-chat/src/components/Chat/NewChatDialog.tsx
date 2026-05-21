import React, { useState } from 'react';
import { X } from "lucide-react";
import { Button } from "@/components/ui/button";
import type { PhoneNumberSummary } from '@/types/chat';

interface Props {
  phones: PhoneNumberSummary[];
  open: boolean;
  onClose: () => void;
  onCreate: (phoneNumber: string, customerWAID: string, customerName?: string) => Promise<void>;
}

export const NewChatDialog: React.FC<Props> = ({ phones, open, onClose, onCreate }) => {
  const [phoneIdx, setPhoneIdx] = useState(0);
  const [waId, setWaId] = useState('');
  const [name, setName] = useState('');
  const [loading, setLoading] = useState(false);

  if (!open) return null;

  const handleSubmit = async () => {
    if (!waId) return;
    setLoading(true);
    try {
      await onCreate(phones[phoneIdx]?.phone_number || waId, waId, name || undefined);
      onClose();
      setWaId('');
      setName('');
    } finally { setLoading(false); }
  };

  return (
    <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/40" onClick={onClose}>
      <div className="bg-white rounded-2xl shadow-2xl w-[400px] max-w-full p-6" onClick={e => e.stopPropagation()}>
        <div className="flex items-center justify-between mb-4">
          <h2 className="text-lg font-bold text-slate-900">Percakapan Baru</h2>
          <Button variant="ghost" size="icon" className="rounded-full h-8 w-8" onClick={onClose}><X className="w-4 h-4" /></Button>
        </div>
        <div className="space-y-3">
          <div>
            <label className="text-xs font-bold text-slate-500 uppercase tracking-wider">Nomor Telefon</label>
            <select className="w-full mt-1 rounded-xl border border-slate-200 px-3 py-2 text-sm bg-white" value={phoneIdx} onChange={e => setPhoneIdx(Number(e.target.value))}>
              {phones.map((p, i) => <option key={p.id} value={i}>{p.phone_number}</option>)}
            </select>
          </div>
          <div>
            <label className="text-xs font-bold text-slate-500 uppercase tracking-wider">WA ID Pelanggan</label>
            <input className="w-full mt-1 rounded-xl border border-slate-200 px-3 py-2 text-sm focus:ring-2 focus:ring-[#00a884] outline-none" placeholder="628123456789" value={waId} onChange={e => setWaId(e.target.value)} />
          </div>
          <div>
            <label className="text-xs font-bold text-slate-500 uppercase tracking-wider">Nama Pelanggan (optional)</label>
            <input className="w-full mt-1 rounded-xl border border-slate-200 px-3 py-2 text-sm focus:ring-2 focus:ring-[#00a884] outline-none" placeholder="Nama" value={name} onChange={e => setName(e.target.value)} />
          </div>
          <Button className="w-full bg-[#00a884] hover:bg-[#00a884]/90 text-white rounded-xl mt-4" onClick={handleSubmit} disabled={!waId || loading}>
            {loading ? 'Memproses...' : 'Mulai Percakapan'}
          </Button>
        </div>
      </div>
    </div>
  );
};
