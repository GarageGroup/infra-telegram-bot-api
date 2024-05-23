namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotApi : IBotMessageApiSupplier, IBotChatApiSupplier, IBotUserApiSupplier, IBotFileGetSupplier, IPingSupplier;