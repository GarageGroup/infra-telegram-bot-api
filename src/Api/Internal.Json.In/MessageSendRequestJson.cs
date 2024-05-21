using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal sealed record class MessageSendRequestJson : IRequestJson<BotMessage>
{
    public static string BotMethod
        =>
        "sendMessage";

    public required long ChatId { get; init; }

    public required string Text { get; init; }

    public BotParseMode ParseMode { get; init; }

    public FlatArray<BotMessageEntity> Entities { get; init; }

    public bool? DisableWebPagePreview { get; init; }

    public bool? DisableNotification { get; init; }

    public bool? ProtectContent { get; init; }

    public int? ReplyToMessageId { get; init; }

    public bool? AllowSendingWithoutReply { get; init; }

    public BotReplyMarkupBase? ReplyMarkup { get; init; }
}