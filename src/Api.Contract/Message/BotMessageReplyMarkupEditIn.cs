﻿using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageReplyMarkupEditIn
{
    public BotMessageReplyMarkupEditIn(long chatId, int messageId)
    {
        ChatId = chatId;
        MessageId = messageId;
        InlineMessageId = null;
    }

    public BotMessageReplyMarkupEditIn(string inlineMessageId)
    {
        ChatId = null;
        MessageId = null;
        InlineMessageId = inlineMessageId.OrEmpty();
    }

    public long? ChatId { get; }

    public int? MessageId { get; }

    public string? InlineMessageId { get; }

    public BotInlineKeyboardMarkup? ReplyMarkup { get; init; }
}