using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotMessageOriginHiddenUser : BotMessageOriginBase
{
    [JsonConstructor]
    public BotMessageOriginHiddenUser([AllowNull] string senderUserName, DateTime date) : base(BotMessageOriginType.HiddenUser, date)
        =>
        SenderUserName = senderUserName.OrEmpty();

    public string SenderUserName { get; }
}