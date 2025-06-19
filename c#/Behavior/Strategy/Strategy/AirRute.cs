using Interface.IRouteStrategy;
using Model;
using Utils;

namespace Strategy
{
    public class AirRute : IRouteStrategy
    {

        private readonly double _speed;

        public AirRute(double speed)
        {
            if (speed < 10 || speed >= 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(speed), "La velocidad debe ser entre 100 y 1000 Km/Hr");
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