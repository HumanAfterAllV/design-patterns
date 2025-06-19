using Interface.IRouteStrategy;
using Model;

namespace Context
{
    public class DeliveryContext
    {
        private IRouteStrategy _strategy;

        public DeliveryContext(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public double GetEstimatedTime(Delivery delivery)
        {
            return _strategy.CalculateTime(delivery.Origin, delivery.Destination);
        }
    }
}
