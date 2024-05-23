using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotUsersShared
{
    [JsonConstructor]
    public BotUsersShared(int requestId, FlatArray<BotSharedUser> users)
    {
        RequestId = requestId;
        Users = users;
    }

    public int RequestId { get; }

    public FlatArray<BotSharedUser> Users { get; }
}