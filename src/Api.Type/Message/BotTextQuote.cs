using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotTextQuote
{
    [JsonConstructor]
    public BotTextQuote(string text)
        =>
        Text = text.OrEmpty();

    public string Text { get; }

    public FlatArray<BotMessageEntity> Entities { get; init; }

    public int Position { get; init; }

    public bool IsManual { get; init; }
}