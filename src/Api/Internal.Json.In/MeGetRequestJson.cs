namespace GarageGroup.Infra.Telegram.Bot;

internal readonly record struct MeGetRequestJson : IRequestJson<BotUser>
{
    public static string BotMethod { get; } = "getMe";
}