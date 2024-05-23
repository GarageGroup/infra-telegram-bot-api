namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotLinkPreviewOptions
{
    public bool? IsDisabled { get; init; }

    public string? Url { get; init; }

    public bool? PreferSmallMedia { get; init; }

    public bool? PreferLargeMedia { get; init; }

    public bool? ShowAboveText { get; init; }
}