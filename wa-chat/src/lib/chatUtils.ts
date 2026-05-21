export const isSameDay = (d1: Date, d2: Date) => d1.getFullYear() === d2.getFullYear() && d1.getMonth() === d2.getMonth() && d1.getDate() === d2.getDate();

export const formatTime = (dateStr: string, timestamp?: number) => {
  const date = timestamp ? new Date(timestamp * 1000) : new Date(dateStr);
  return date.toLocaleTimeString('id-ID', { hour: '2-digit', minute: '2-digit' });
};

export const formatTimeConversation = (dateStr: string, timestamp?: number) => {
  const date = timestamp ? new Date(timestamp * 1000) : new Date(dateStr);
  if (isSameDay(date, new Date())) return formatTime(dateStr, timestamp);
  if (isSameDay(date, new Date(new Date().setDate(new Date().getDate() - 1)))) return 'Kemarin';
  return date.toLocaleDateString('id-ID', { day: 'numeric', month: 'long', year: date.getFullYear() !== new Date().getFullYear() ? 'numeric' : undefined });
};

export const formatDividerDate = (dateStr: string, timestamp?: number) => {
  const date = timestamp ? new Date(timestamp * 1000) : new Date(dateStr);
  const now = new Date();
  const yesterday = new Date(now); yesterday.setDate(now.getDate() - 1);
  if (isSameDay(date, now)) return 'Hari Ini';
  if (isSameDay(date, yesterday)) return 'Kemarin';
  return date.toLocaleDateString('id-ID', { day: 'numeric', month: 'long', year: date.getFullYear() !== now.getFullYear() ? 'numeric' : undefined });
};

export const getInitials = (name: string) => {
  if (!name) return '?';
  const words = name.split(' ').filter(w => w.length > 0);
  if (words.length > 1) return ([...words[0]][0] + [...words[words.length - 1]][0]).toUpperCase();
  return [...name.trim()][0].toUpperCase();
};

export const truncateText = (text: string, limit: number) => {
  if (!text) return text;
  const chars = [...text];
  if (chars.length <= limit) return text;
  return chars.slice(0, limit).join('') + '...';
};
