namespace Map.Icon
{
    public class Icon
    {
        private readonly string Type;
        private readonly string ImagePath;
        public Icon(string Type, string ImagePath)
        {
            this.Type = Type;
            this.ImagePath = ImagePath;
        }

        public static void Render(Icon icon, double latitud, double longitude)
        {
            Console.WriteLine($"Render icon type {icon.Type.ToUpper()} at {latitud} - {longitude}using image: {icon.ImagePath}");
        }
    }
}