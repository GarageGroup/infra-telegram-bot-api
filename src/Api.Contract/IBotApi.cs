namespace GarageGroup.Infra.Telegram.Bot;

public interface IBotApi : IBotMessageApiSupplier, IBotWidgetApiSupplier, IBotChatApiSupplier, IBotUserApiSupplier, IBotFileGetSupplier, IPingSupplier;