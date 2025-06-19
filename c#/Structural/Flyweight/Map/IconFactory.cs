namespace Map.IconFactory
{
    public class IconFactory
    {
        private static readonly IconFactory _instance = new IconFactory();
        private readonly Dictionary<string, Icon.Icon> Icons = new Dictionary<string, Icon.Icon>();
        public static IconFactory Instance => _instance;

        public IconFactory()
        {
            Icons = new Dictionary<string, Icon.Icon>();
        }

        public Icon.Icon GetIcon(string IconType)
        {

            if (!Icons.ContainsKey(IconType))
            {
                Console.WriteLine($"🆕 Creating new icon fro: ${IconType}");
                string path = $"/icons/{IconType}.png";
                Icon.Icon icon = new Icon.Icon(IconType, path);
                Icons.Add(IconType, icon);
            }
            else
            {
                Console.WriteLine($"✅ Reusing icon for: {IconType}");
            }

            return Icons[IconType];
        }
    } 
}