using Interface.IObserver;

namespace Observer.Logger
{
    public class LoggerAction : IObserver
    {
        public void Update(string symbol, double price)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now}: 📝 Log {symbol} is now at {price}");
        }

    }
}