using System;

namespace GarageGroup.Infra.Telegram.Bot;

// A state that is null is not changed, and an empty state is removed
public sealed record class BotMessageWidgetDataEditIn
{
    public BotMessageWidgetDataEditIn(long chatId, int messageId)
    {
        ChatId = chatId;
        MessageId = messageId;
        InlineMessageId = null;
    }

    public BotMessageWidgetDataEditIn(string inlineMessageId)
    {
        ChatId = null;
        MessageId = null;
        InlineMessageId = inlineMessageId.OrEmpty();
    }

    public long? ChatId { get; }

    public int? MessageId { get; }

    public string? InlineMessageId { get; }

    public string? PublicData { get; init; }

    public string? ChatData { get; init; }
}
