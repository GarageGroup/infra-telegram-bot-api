using System;

namespace GarageGroup.Infra.Telegram.Bot;

public abstract record class BotMessageOriginBase
{
    private protected BotMessageOriginBase(BotMessageOriginType type, DateTime date)
    {
        Type = type;
        Date = date;
    }

    public BotMessageOriginType Type { get; }

    public DateTime Date { get; }
}