namespace GarageGroup.Infra.Telegram.Bot;

internal sealed record class RichMessageSendRequestJson : IRequestJson<BotMessage>
{
    public static string BotMethod { get; } = "sendRichMessage";

    public required long ChatId { get; init; }

    public required BotInputRichMessage RichMessage { get; init; }

    public string? BusinessConnectionId { get; init; }

    public int? MessageThreadId { get; init; }

    public bool? DisableNotification { get; init; }

    public bool? ProtectContent { get; init; }

    public string? MessageEffectId { get; init; }

    public BotReplyParameters? ReplyParameters { get; init; }

    public BotReplyMarkupBase? ReplyMarkup { get; init; }
}
