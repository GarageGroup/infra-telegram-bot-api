using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotRichMessageSendIn
{
    public BotRichMessageSendIn(long chatId, BotInputRichMessage richMessage)
    {
        ChatId = chatId;
        RichMessage = richMessage ?? throw new ArgumentNullException(nameof(richMessage));
    }

    public long ChatId { get; }

    public BotInputRichMessage RichMessage { get; }

    public string? BusinessConnectionId { get; init; }

    public int? MessageThreadId { get; init; }

    public bool? DisableNotification { get; init; }

    public bool? ProtectContent { get; init; }

    public string? MessageEffectId { get; init; }

    public BotReplyParameters? ReplyParameters { get; init; }

    public BotReplyMarkupBase? ReplyMarkup { get; init; }
}
