using Interface.IObserver;

namespace Observer.PriceAlertBot
{
    public class PriceAlertBotDetails : IObserver
    {
        private double threshold;

        public PriceAlertBotDetails(double threshold)
        {
            this.threshold = threshold;
        }

        public void Update(string symbol, double price)
        {
            if (price < threshold)
            {
                Console.WriteLine($"⚠️ ALERT! {symbol} dropped below {threshold}");
            }
        }
    }
}