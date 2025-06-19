namespace Model
{
    public class Location
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public Location(double latitud, double longitud)
        {
            if (latitud < -90 || latitud > 90)
            {
                throw new ArgumentOutOfRangeException(nameof(latitud), "Latitude must be between -90 and 90.");
            }
            if (longitud < -180 || longitud > 180)
            {
                throw new ArgumentOutOfRangeException(nameof(longitud), "Longitude must be between -180 and 180.");
            }
            Latitud = latitud;
            Longitud = longitud;
        }

        public override string ToString()
        {
            return $"{Latitud} - {Longitud}";
        }
    }
}