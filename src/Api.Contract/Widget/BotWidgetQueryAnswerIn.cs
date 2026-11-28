using System;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotWidgetQueryAnswerIn
{
    public BotWidgetQueryAnswerIn(string widgetQueryId)
        =>
        WidgetQueryId = widgetQueryId.OrEmpty();

    public string WidgetQueryId { get; }

    // The data returned to the widget that has sent the query, up to 1024 bytes. It does not change the state of the widget
    public string? Data { get; init; }
}
