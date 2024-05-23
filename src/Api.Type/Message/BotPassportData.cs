using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotPassportData
{
    [JsonConstructor]
    public BotPassportData(FlatArray<BotEncryptedPassportElement> data, BotEncryptedCredentials credentials)
    {
        Data = data;
        Credentials = credentials ?? new(string.Empty, string.Empty, string.Empty);
    }

    public FlatArray<BotEncryptedPassportElement> Data { get; }

    public BotEncryptedCredentials Credentials { get; }
}