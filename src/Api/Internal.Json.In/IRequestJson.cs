namespace GarageGroup.Infra.Telegram.Bot;

internal interface IRequestJson<TResultJson>
{
    static abstract string BotMethod { get; }
}