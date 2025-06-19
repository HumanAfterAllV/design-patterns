using Interface.IRouteStrategy;
using Model;
using Utils;

namespace Strategy
{
    public class SeaRute : IRouteStrategy
    {
        private readonly double _speed;

        public SeaRute(double speed)
        {
            if (speed < 1 || speed >= 60)
            {
                throw new ArgumentOutOfRangeException(nameof(speed), "La velocidad debe ser entre 1 a 60 Km/Hr");
            }

            _speed = speed;
        }
        public double CalculateTime(Location origin, Location destination)
        {
            var calculator = new GeoCalculator();
            double distance = calculator.CalculateDistance(origin, destination);

            return distance / _speed;
        }
    }
}