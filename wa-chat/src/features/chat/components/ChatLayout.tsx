import React, { useState, useCallback, useEffect } from 'react';
import { TooltipProvider } from "@/components/ui/tooltip";
import ChatSidebar from './ChatSidebar';
import ConversationSidebar from './ConversationSidebar';
import ChatWindow from './ChatWindow';
import ConnectionBanner from './ConnectionBanner';
import { NewChatDialog } from '@/components/Chat/NewChatDialog';
import { useChatConnection } from '@/hooks/useChatConnection';
import { useConversations } from '@/hooks/useConversations';
import { useMessages } from '@/hooks/useMessages';
import { useChatActions } from '@/hooks/useChatActions';
import type { Conversation, ChatMessage } from '@/types/chat';

const ChatLayout: React.FC = () => {
  const { status, connect } = useChatConnection();
  const [activePhoneId, setActivePhoneId] = useState<string | null>(null);
  const [activeConversation, setActiveConversation] = useState<Conversation | null>(null);
  const [searchTerm, setSearchTerm] = useState('');
  const [convFilter, setConvFilter] = useState<'all' | 'unread' | 'read'>('all');
  const [replyingTo, setReplyingTo] = useState<ChatMessage | null>(null);
  const [newChatOpen, setNewChatOpen] = useState(false);

  const {
    conversations, phones, loading: convsLoading, hasMore, typingAgents,
    loadMore, setSearch, setFilter, markRead, loadPhones,
  } = useConversations(activePhoneId);

  const { messages, loading: msgsLoading, hasMore: msgsHasMore, loadMore: loadMoreMsgs, addMessage } = useMessages(
    activeConversation?.id ?? null, markRead
  );

  const { handleSend, handleSendMedia, handleSendReaction, handleEnsureConv } = useChatActions(activeConversation, addMessage);

  useEffect(() => { connect(); }, [connect]);

  const onNewChatCreated = useCallback(async (phoneNumber: string, customerWAID: string, customerName?: string) => {
    await handleEnsureConv(phoneNumber, customerWAID, customerName);
  }, [handleEnsureConv]);

  const conversationSidebarConvFilter = convFilter;

  return (
    <TooltipProvider>
      <div className="flex h-screen w-screen bg-[#f0f2f5] overflow-hidden fixed inset-0 font-sans">
        <ConnectionBanner status={status} onRetry={() => connect()} />
        <ChatSidebar phones={phones} totalUnread={phones.reduce((a, b) => a + b.unread_count, 0)}
          activePhoneId={activePhoneId} setActivePhoneId={setActivePhoneId} onRefresh={loadPhones} />
        <ConversationSidebar conversations={conversations} activeConversation={activeConversation} setActiveConversation={setActiveConversation}
          searchTerm={searchTerm} setSearchTerm={(s) => { setSearchTerm(s); setSearch(s); }}
          convFilter={conversationSidebarConvFilter} setConvFilter={(f) => { setConvFilter(f); setFilter(f); }}
          typingAgents={typingAgents} loading={convsLoading} hasMore={hasMore} onLoadMore={loadMore} onNewChat={() => setNewChatOpen(true)} />
        <ChatWindow activeConversation={activeConversation} messages={messages}
          typingAgents={typingAgents} loading={msgsLoading} hasMore={msgsHasMore}
          onLoadMore={loadMoreMsgs} onSend={handleSend} onSendMedia={handleSendMedia}
          onReaction={handleSendReaction}
          replyingTo={replyingTo} setReplyingTo={setReplyingTo} />
        <NewChatDialog phones={phones} open={newChatOpen} onClose={() => setNewChatOpen(false)} onCreate={onNewChatCreated} />
      </div>
    </TooltipProvider>
  );
};

export default ChatLayout;
