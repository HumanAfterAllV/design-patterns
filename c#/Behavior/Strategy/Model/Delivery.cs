namespace Model
{
    public class Delivery
    {
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public double Load { get; set; }

        public Delivery(Location origin, Location destination, double load)
        {
            if (Load < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Load), "La carga no debe ser menor a 0");
            }

            Origin = origin;
            Destination = destination;
            Load = load;
        }

        public override string ToString()
        {
            return $"From {Origin.Latitud}, {Origin.Longitud} to {Destination.Latitud}, {Destination.Longitud} - Load {Load} Kg";
        }
    }
}