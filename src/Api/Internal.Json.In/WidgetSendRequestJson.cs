using System;

namespace GarageGroup.Infra.Telegram.Bot;

internal sealed record class WidgetSendRequestJson : IRequestJson<BotMessage>
{
    public static string BotMethod { get; } = "sendWidget";

    public required long ChatId { get; init; }

    public required string Html { get; init; }

    public int? MessageThreadId { get; init; }

    public int? Width { get; init; }

    public int? Height { get; init; }

    public string? PublicData { get; init; }

    public string? ChatData { get; init; }

    public string? Caption { get; init; }

    public BotParseMode ParseMode { get; init; }

    public FlatArray<BotMessageEntity> CaptionEntities { get; init; }

    public bool? ShowCaptionAboveMedia { get; init; }

    public bool? AllowQueries { get; init; }

    public bool? IsShared { get; init; }

    public bool? DisableNotification { get; init; }

    public bool? ProtectContent { get; init; }

    public string? MessageEffectId { get; init; }

    public BotReplyParameters? ReplyParameters { get; init; }

    public BotReplyMarkupBase? ReplyMarkup { get; init; }
}
