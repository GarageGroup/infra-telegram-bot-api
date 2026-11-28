using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

// A query from a forwarded message with a shared widget created by the bot. It must be answered within 15 seconds
public sealed record class BotSharedWidgetQuery
{
    [JsonConstructor]
    public BotSharedWidgetQuery(string id, BotUser from, string data, string widgetId)
    {
        Id = id.OrEmpty();
        From = from;
        Data = data.OrEmpty();
        WidgetId = widgetId.OrEmpty();
    }

    public string Id { get; }

    public BotUser From { get; }

    public string Data { get; }

    public string WidgetId { get; }

    public BotWidgetQueryType? Type { get; init; }
}
