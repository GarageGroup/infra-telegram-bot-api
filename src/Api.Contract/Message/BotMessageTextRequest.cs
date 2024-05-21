using System;
using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageTextEditIn
{
    public BotMessageTextEditIn(long chatId, int messageId, [AllowNull] string text = BotMessageSendIn.TelegramEmptyText)
    {
        ChatId = chatId;
        MessageId = messageId;
        InlineMessageId = null;
        Text = text.OrNullIfEmpty() ?? BotMessageSendIn.TelegramEmptyText;
    }

    public BotMessageTextEditIn(string inlineMessageId, [AllowNull] string text = BotMessageSendIn.TelegramEmptyText)
    {
        ChatId = null;
        MessageId = null;
        InlineMessageId = inlineMessageId.OrEmpty();
        Text = text.OrNullIfEmpty() ?? BotMessageSendIn.TelegramEmptyText;
    }

    public long? ChatId { get; }

    public int? MessageId { get; }

    public string? InlineMessageId { get; }

    public string Text { get; }

    public BotParseMode ParseMode { get; init; }

    public FlatArray<BotMessageEntity> Entities { get; init; }

    public BotInlineKeyboardMarkup? ReplyMarkup { get; init; }
}