using Interface.IObserver;

namespace Observer.Graph
{
    public class GraphDetails : IObserver
    {
        public void Update(string symbol, double price)
        {
            Console.WriteLine($"📈 Updating graph for {symbol}: {price}");
        }
    }
}