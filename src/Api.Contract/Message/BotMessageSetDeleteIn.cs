using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageSetDeleteIn
{
    public BotMessageSetDeleteIn(long chatId, FlatArray<int> messageIds)
    {
        ChatId = chatId;
        MessageIds = messageIds;
    }

    public long ChatId { get; }

    public FlatArray<int> MessageIds { get; }
}