using Model;

namespace Utils
{
    public class GeoCalculator
    {
        public double CalculateDistance(Location origin, Location destination)
        {
            const double R = 6371e3;
            var lat1 = DegreesToRadians(origin.Latitud);
            var lat2 = DegreesToRadians(destination.Latitud);
            var long1 = DegreesToRadians(origin.Longitud);
            var lon2 = DegreesToRadians(destination.Longitud);

            var dLat = lat1 - lat2;
            var dLong = long1 - lon2;

            var a = Math.Pow(Math.Sin(dLat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dLong / 2), 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var distance = R * c;

            return distance / 1000;

        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }
}