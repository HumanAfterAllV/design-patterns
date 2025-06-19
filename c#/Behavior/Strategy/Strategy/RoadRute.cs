using Interface.IRouteStrategy;
using Model;
using Utils;

namespace Strategy
{
    public class RoadRute : IRouteStrategy
    {
        private readonly double _speed;

        public RoadRute(double speed)
        {
            if (speed < 1 || speed >= 300)
            {
                throw new ArgumentOutOfRangeException(nameof(speed), "La velocidad debe ser entre 1 a 300 Km/Hr");
            }

            _speed = speed;
        }
        public double CalculateTime(Location origin, Location destination)
        {
            var calulator = new GeoCalculator();
            double distance = calulator.CalculateDistance(origin, destination);

            return distance / _speed;
        }

    }
}