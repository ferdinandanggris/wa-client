import React from 'react';
import { RefreshCw, Server } from "lucide-react";
import { Button } from "@/components/ui/button";
import { cn } from '@/lib/utils';

interface Props {
  status: 'connected' | 'connecting' | 'disconnected' | 'reconnecting';
  onRetry?: () => void;
  onFindServer?: () => void;
}

const ConnectionBanner: React.FC<Props> = ({ status, onRetry, onFindServer }) => {
  if (status === 'connected') return null;

  const config = {
    connecting: { bg: 'bg-amber-500', text: 'Menghubungkan ke server...' },
    disconnected: { bg: 'bg-red-500', text: 'Koneksi terputus. Mencoba menghubungkan kembali...' },
    reconnecting: { bg: 'bg-amber-500', text: 'Mencoba menghubungkan kembali...' },
  };

  const c = config[status];
  return (
    <div className={cn("absolute top-0 left-0 right-0 z-50 py-1.5 px-4 flex items-center justify-center gap-3", c.bg)}>
      <span className="text-white text-[11px] font-medium">{c.text}</span>
      {status === 'disconnected' && (
        <div className="flex gap-2">
          {onRetry && <Button variant="secondary" size="sm" className="h-6 text-[10px] px-2 rounded" onClick={onRetry}><RefreshCw className="w-3 h-3 mr-1" />Retry</Button>}
          {onFindServer && <Button variant="secondary" size="sm" className="h-6 text-[10px] px-2 rounded" onClick={onFindServer}><Server className="w-3 h-3 mr-1" />Find Server</Button>}
        </div>
      )}
    </div>
  );
};

export default ConnectionBanner;
