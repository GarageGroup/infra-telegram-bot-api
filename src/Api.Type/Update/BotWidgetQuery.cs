using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

// A query from a widget in a message sent by the bot or via the bot. It must be answered within 15 seconds
public sealed record class BotWidgetQuery
{
    [JsonConstructor]
    public BotWidgetQuery(string id, BotUser from, string chatInstance, string data)
    {
        Id = id.OrEmpty();
        From = from;
        ChatInstance = chatInstance.OrEmpty();
        Data = data.OrEmpty();
    }

    public string Id { get; }

    public BotUser From { get; }

    public string ChatInstance { get; }

    // The data of the query, 1-64 bytes. It comes from the code of the widget, so it must be checked like any user input
    public string Data { get; }

    public BotChat? Chat { get; init; }

    public int? MessageId { get; init; }

    public string? InlineMessageId { get; init; }

    public string? ChatType { get; init; }

    public BotWidgetQueryType? Type { get; init; }

    // The identifier of the shared widget; null if the widget is not shared
    public string? WidgetId { get; init; }
}
