using Imp;
using Dto;

public class Program
{
    static void Main()
    {
            new CRMModule().Activate();
            new NotifyModule().Activate();
            new StockModule().Activate();
            new PurchaseModule().Activate();
            
            EccomerceModule client = new EccomerceModule();
            client.Activate();
            
            Sale sale = new Sale();
            for(int c=0;c<5;c++){
                sale.AddProduct(new Product("Product" + (c+1)));
            }
            client.CreateSale(sale);
    }
}
