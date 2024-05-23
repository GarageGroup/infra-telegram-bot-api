using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotSharedUser
{
    [JsonConstructor]
    public BotSharedUser(long userId)
        =>
        UserId = userId;

    public long UserId { get; }

    public string? FirstName { get; init; }

    public string? LastName { get; init; }

    public string? Username { get; init; }

    public FlatArray<BotPhotoSize> Photo { get; init; }
}