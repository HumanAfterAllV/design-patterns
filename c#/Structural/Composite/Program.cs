using Products;
using Orders;


public class CompositeMain
{
    private SimpleProduct ram4gb;
    private SimpleProduct ram8gb;
    private SimpleProduct disk500gb;
    private SimpleProduct disk1tb;
    private SimpleProduct cpuAMD;
    private SimpleProduct cpuIntel;
    private SimpleProduct smallCabinete;
    private SimpleProduct bigCabinete;
    private SimpleProduct monitor20inch;
    private SimpleProduct monitor30inch;
    private SimpleProduct simpleMouse;
    private SimpleProduct gammerMouse;

    private CompositeProducts gammerPC;
    private CompositeProducts homePC;
    private CompositeProducts pc2x1;

    public void BuildProducts()
    {
        // Simple product construction
        ram4gb = new SimpleProduct("RAM 4GB", 750, "KingStone");
        ram8gb = new SimpleProduct("RAM 8GB", 1000, "KingStone");
        disk500gb = new SimpleProduct("HDD 500GB", 1500, "ACME");
        disk1tb = new SimpleProduct("HDD 1TB", 2000, "ACME");
        cpuAMD = new SimpleProduct("AMD phenon", 4000, "AMD");
        cpuIntel = new SimpleProduct("Intel i7", 4500, "Intel");
        smallCabinete = new SimpleProduct("Small cabinet", 2000, "ExCom");
        bigCabinete = new SimpleProduct("Big Cabinet", 2200, "ExCom");
        monitor20inch = new SimpleProduct("Display 20'", 1500, "HP");
        monitor30inch = new SimpleProduct("Display 30'", 2000, "HP");
        simpleMouse = new SimpleProduct("Simple mouse", 150, "Genius");
        gammerMouse = new SimpleProduct("Gammer mouse", 750, "Alien");

        // Gammer PC
        gammerPC = new CompositeProducts("Gammer PC");
        gammerPC.AddProduct(ram8gb);
        gammerPC.AddProduct(disk1tb);
        gammerPC.AddProduct(cpuIntel);
        gammerPC.AddProduct(bigCabinete);
        gammerPC.AddProduct(monitor30inch);
        gammerPC.AddProduct(gammerMouse);

        // Home PC
        homePC = new CompositeProducts("Home PC");
        homePC.AddProduct(ram4gb);
        homePC.AddProduct(disk500gb);
        homePC.AddProduct(cpuAMD);
        homePC.AddProduct(smallCabinete);
        homePC.AddProduct(monitor20inch);
        homePC.AddProduct(simpleMouse);

        // Combo PC
        pc2x1 = new CompositeProducts("Pack PC Gammer + Home PC");
        pc2x1.AddProduct(gammerPC);
        pc2x1.AddProduct(homePC);
    }

    public void OrderSimpleProducts()
    {
        var random = new Random();
        var simpleProductOrder = new Order(random.Next(0, 1000), "Galicia Raúl");
        simpleProductOrder.AddProduct(ram4gb);
        simpleProductOrder.AddProduct(disk1tb);
        simpleProductOrder.AddProduct(simpleMouse);
        simpleProductOrder.PrintOrder();
    }

    public void OrderGammerPC()
    {
        var gammerOrder = new Order(1, "Juan Perez");
        gammerOrder.AddProduct(gammerPC);
        gammerOrder.PrintOrder();
    }

    public void OrderHomePC()
    {
        var homeOrder = new Order(2, "Marcos Guerra");
        homeOrder.AddProduct(homePC);
        homeOrder.PrintOrder();
    }

    public void OrderCombo()
    {
        var comboOrder = new Order(3, "Paquete 2x1 en PC");
        comboOrder.AddProduct(pc2x1);
        comboOrder.PrintOrder();
    }

    public void OrderBig()
    {
        var customOrder = new Order(4, "Israel Galicia");
        customOrder.AddProduct(homePC);
        customOrder.AddProduct(ram8gb);
        customOrder.AddProduct(ram4gb);
        customOrder.AddProduct(monitor30inch);
        customOrder.AddProduct(gammerMouse);
        customOrder.PrintOrder();
    }
}

// Main execution
public class Program
{
    public static void Main(string[] args)
    {
        var main = new CompositeMain();
        main.BuildProducts();

        main.OrderSimpleProducts();
        main.OrderHomePC();
        main.OrderGammerPC();
        main.OrderCombo();
        main.OrderBig();
    }
}