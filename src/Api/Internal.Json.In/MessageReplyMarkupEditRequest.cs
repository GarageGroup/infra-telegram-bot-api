namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct MessageReplyMarkupEditRequestJson : IRequestJson<BotMessage?>
{
    public static string BotMethod
        =>
        "editMessageReplyMarkup";

    public required long? ChatId { get; init; }

    public required int? MessageId { get; init; }

    public required string? InlineMessageId { get; init; }

    public BotInlineKeyboardMarkup? ReplyMarkup { get; init; }
}
