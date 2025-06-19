using Subject;
using Observer.Graph;
using Observer.Logger;
using Observer.PriceAlertBot;

public class Program
{
    static void Main()
    {
        var ticker = new StockTricker();

        ticker.Subscribe(new GraphDetails());
        ticker.Subscribe(new LoggerAction());
        ticker.Subscribe(new PriceAlertBotDetails(100));

        ticker.SetPrice("MSFT", 120);
        ticker.SetPrice("MSFT", 90);
    }
}