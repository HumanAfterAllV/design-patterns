using Interface.IObserver;

namespace Subject
{
    public class StockTricker
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetPrice(string symbol, double price)
        {
            Console.WriteLine($"📢 New price for {symbol}: {price}");
            NotifyObservers(symbol, price);

        }

        private void NotifyObservers(string symbol, double price)
        {
            foreach (var observer in observers)
            {
                observer.Update(symbol, price);
            }
        }
    }
}