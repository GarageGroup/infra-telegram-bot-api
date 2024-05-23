using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotProximityAlertTriggered
{
    [JsonConstructor]
    public BotProximityAlertTriggered(BotUser traveler, BotUser watcher, int distance)
    {
        Traveler = traveler;
        Watcher = watcher;
        Distance = distance;
    }

    public BotUser Traveler { get; }

    public BotUser Watcher { get; }

    public int Distance { get; }
}