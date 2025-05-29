using Proxy.Proxy;

public class Program
{
    static void Main()
    {
        var roles = new Dictionary<string, string>
        {
            { "Doctor", "Doctor" },
            { "Admin", "Admin" }
        };

        var proxy = new ProxyDocument("Patient.pdf", null, roles);

        try
        {
            proxy.Display("Admin").Wait();

        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
        }
        Console.WriteLine("*--------*");
    }
}
