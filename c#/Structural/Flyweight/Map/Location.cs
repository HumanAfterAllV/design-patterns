namespace Map.Location
{
    public class Location
    {
        private readonly string Name;
        private readonly double Long;
        private readonly double Lat;
        private readonly Icon.Icon Icon;

        public Location(double Lat, double Long, Icon.Icon icon, string Name)
        {
            this.Lat = Lat;
            this.Long = Long;
            Icon = icon ?? throw new ArgumentNullException(nameof(icon));
            this.Name = Name;
        }

        public void Draw()
        {
            Console.WriteLine($"{Name}");
            Map.Icon.Icon.Render(Icon, Lat, Long);
        }
    }
}