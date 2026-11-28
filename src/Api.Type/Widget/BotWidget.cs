using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

// An HTML widget of a message: fixed code and a state that only the bot changes
public sealed record class BotWidget
{
    [JsonConstructor]
    public BotWidget(string html)
        =>
        Html = html.OrEmpty();

    // The identifier of a shared widget; null if the widget is not shared
    public string? Id { get; init; }

    public int? Width { get; init; }

    public int? Height { get; init; }

    public string Html { get; }

    // The state that is available wherever the widget is shown
    public string? PublicData { get; init; }

    // The state of the widget in this message
    public string? ChatData { get; init; }
}
