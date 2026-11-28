using System;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

public sealed record class BotWidgetQueryType
{
    public const string DataType = "data";

    public const string SignDataType = "sign_data";

    public const string SentTransactionType = "sent_transaction";

    [JsonConstructor]
    public BotWidgetQueryType(string type)
        =>
        Type = type.OrEmpty();

    public string Type { get; }

    // JSON-serialized signed data of a query of the type 'sign_data'
    public string? SignData { get; init; }

    // The hash of the transaction of a query of the type 'sent_transaction'
    public string? MsgHash { get; init; }
}
