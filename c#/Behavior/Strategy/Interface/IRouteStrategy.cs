using Model;

namespace Interface.IRouteStrategy
{
    public interface IRouteStrategy
    {
        public double CalculateTime(Location origin, Location destiny);
    }
}