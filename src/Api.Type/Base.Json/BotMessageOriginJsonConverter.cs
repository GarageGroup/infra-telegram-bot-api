using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Telegram.Bot;

internal sealed class BotMessageOriginJsonConverter : JsonConverter<BotMessageOriginBase>
{
    public override BotMessageOriginBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDocument = JsonDocument.ParseValue(ref reader);

        if (jsonDocument is null)
        {
            return null;
        }

        var statusJsonElement = GetTypeJsonElement(jsonDocument, options);

        return GetOriginType(statusJsonElement, options) switch
        {
            BotMessageOriginType.User => jsonDocument.Deserialize<BotMessageOriginUser>(options),
            BotMessageOriginType.HiddenUser => jsonDocument.Deserialize<BotMessageOriginHiddenUser>(options),
            BotMessageOriginType.Chat => jsonDocument.Deserialize<BotMessageOriginChat>(options),
            BotMessageOriginType.Channel => jsonDocument.Deserialize<BotMessageOriginChannel>(options),
            var unexpected => throw new JsonException($"Bot message origin type {unexpected} is unexpected")
        };
    }

    public override void Write(Utf8JsonWriter writer, BotMessageOriginBase value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            writer.WriteNullValue();
            return;
        }

        if (value is BotMessageOriginUser originUser)
        {
            JsonSerializer.Serialize(writer, originUser, options);
            return;
        }

        if (value is BotMessageOriginHiddenUser originHiddenUser)
        {
            JsonSerializer.Serialize(writer, originHiddenUser, options);
            return;
        }

        if (value is BotMessageOriginChat originChat)
        {
            JsonSerializer.Serialize(writer, originChat, options);
            return;
        }

        if (value is BotMessageOriginChannel originChannel)
        {
            JsonSerializer.Serialize(writer, originChannel, options);
            return;
        }

        throw new NotSupportedException($"Type {value.GetType()} serialization is not supported");
    }

    private static BotMessageOriginType GetOriginType(JsonElement jsonElement, JsonSerializerOptions options)
    {
        if (jsonElement.ValueKind is JsonValueKind.Number)
        {
            return (BotMessageOriginType)jsonElement.GetInt32();
        }

        if (jsonElement.ValueKind is not JsonValueKind.String)
        {
            throw new JsonException($"Origin type value kind {jsonElement.ValueKind} is unexpected");
        }

        var originTypeName = jsonElement.GetString();
        var namingPolicy = options.PropertyNamingPolicy;

        foreach (var originType in Enum.GetValues<BotMessageOriginType>())
        {
            var name = originType.ToString();
            if (namingPolicy is not null)
            {
                name = namingPolicy.ConvertName(name);
            }

            if (string.Equals(originTypeName, name, StringComparison.InvariantCultureIgnoreCase))
            {
                return originType;
            }
        }

        throw new InvalidOperationException($"An unexpected origin type name: '{originTypeName}'");
    }

    private static JsonElement GetTypeJsonElement(JsonDocument jsonDocument, JsonSerializerOptions options)
    {
        var propertyName = nameof(BotMessageOriginBase.Type);
        if (options.PropertyNamingPolicy is not null)
        {
            propertyName = options.PropertyNamingPolicy.ConvertName(propertyName);
        }

        if (jsonDocument.RootElement.TryGetProperty(propertyName, out var jsonElement))
        {
            return jsonElement;
        }

        throw new JsonException($"Property {propertyName} must be specified");
    }
}