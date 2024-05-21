using System;
using PrimeFuncPack;

namespace GarageGroup.Infra.Telegram.Bot;

public static class BotApiDependency
{
    public static Dependency<IBotApi> UseTelegramBotApi(this Dependency<IHttpApi> dependency)
    {
        ArgumentNullException.ThrowIfNull(dependency);
        return dependency.Map<IBotApi>(CreateApi);

        static BotApi CreateApi(IHttpApi httpApi)
        {
            ArgumentNullException.ThrowIfNull(httpApi);
            return new(httpApi);
        }
    }
}