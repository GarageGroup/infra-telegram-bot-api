using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotSharedWidgetSendIn
{
    public BotSharedWidgetSendIn(long chatId, string widgetId)
    {
        ChatId = chatId;
        WidgetId = widgetId.OrEmpty();
    }

    public long ChatId { get; }

    public string WidgetId { get; }

    public int? MessageThreadId { get; init; }

    // The state of the widget in this message, up to 1024 bytes
    public string? ChatData { get; init; }

    // The caption is shown instead of the widget by the apps that do not support widgets
    public string? Caption { get; init; }

    public BotParseMode ParseMode { get; init; }

    public FlatArray<BotMessageEntity> CaptionEntities { get; init; }

    public bool? ShowCaptionAboveMedia { get; init; }

    public bool? DisableNotification { get; init; }

    public bool? ProtectContent { get; init; }

    public string? MessageEffectId { get; init; }

    public BotReplyParameters? ReplyParameters { get; init; }

    public BotReplyMarkupBase? ReplyMarkup { get; init; }
}
