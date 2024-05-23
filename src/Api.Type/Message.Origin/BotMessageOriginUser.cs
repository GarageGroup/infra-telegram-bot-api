using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageOriginUser : BotMessageOriginBase
{
    [JsonConstructor]
    public BotMessageOriginUser(BotUser senderUser, DateTime date) : base(BotMessageOriginType.User, date)
        =>
        SenderUser = senderUser;

    public BotUser SenderUser { get; }
}