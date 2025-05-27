using Map.IconFactory;
using Map.Location;


public class Program()
{
    public static void Main(string[] args)
    {
        var factory = IconFactory.Instance;

        var hospitalIcon = factory.GetIcon("Hospital");
        var hospitalIcon2 = factory.GetIcon("Hospital");
        var schoolIcon = factory.GetIcon("School");

        var locationOne = new Location(19.4, -99.1, hospitalIcon, "Hospital Central");
        var locationTwo = new Location(20.4, 50.1, hospitalIcon2, "Hospital Central");
        var locationThree = new Location(45.5, 150.88, schoolIcon, "School");

        locationOne.Draw();
        locationTwo.Draw();
        locationThree.Draw();

    }
}
