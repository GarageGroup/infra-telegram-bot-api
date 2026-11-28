using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotWidgetSendIn
{
    public BotWidgetSendIn(long chatId, string html)
    {
        ChatId = chatId;
        Html = html.OrEmpty();
    }

    public long ChatId { get; }

    // The HTML code of the widget: up to 32768 bytes and up to 4096 bytes when compressed
    public string Html { get; }

    public int? MessageThreadId { get; init; }

    public int? Width { get; init; }

    public int? Height { get; init; }

    // The state that is available wherever the widget is shown, up to 1024 bytes
    public string? PublicData { get; init; }

    // The state of the widget in this message, up to 1024 bytes
    public string? ChatData { get; init; }

    // The caption is shown instead of the widget by the apps that do not support widgets
    public string? Caption { get; init; }

    public BotParseMode ParseMode { get; init; }

    public FlatArray<BotMessageEntity> CaptionEntities { get; init; }

    public bool? ShowCaptionAboveMedia { get; init; }

    // Allows the widget to send queries to the bot
    public bool? AllowQueries { get; init; }

    // Creates a shared widget, which can be sent again by its identifier
    public bool? IsShared { get; init; }

    public bool? DisableNotification { get; init; }

    public bool? ProtectContent { get; init; }

    public string? MessageEffectId { get; init; }

    public BotReplyParameters? ReplyParameters { get; init; }

    public BotReplyMarkupBase? ReplyMarkup { get; init; }
}
