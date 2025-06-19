using Models;
using Orders;
using Validators;

class Program
{
    static void Main()
    {

        SalesOrder salesOrder = new SalesOrder();
        salesOrder.DeliveryDate = DateTime.Now;

        Customer customer = new Customer();
        customer.Name = "Israel Galicia";
        customer.Rfc = "XX00XX000X";
        customer.Status = Status.ACTIVO;

        Telephone phone = new Telephone();
        phone.Number = "2721234567";
        phone.Ext = "123";
        phone.Lada = "52";
        customer.Telephone = phone;

        Address address = new Address();
        address.Address1 = "Col. Benito Juarez";
        address.Address2 = "Departamento #456";
        address.CP = "123456";
        address.Country = "Mexico";
        customer.Address = address;

        CreditData creditData = new CreditData();
        creditData.Balance = 1000;
        creditData.CreditLimit = 13000;
        customer.CreditData = creditData;

        salesOrder.Contributor = customer;

        List<OrderItem> orderItems = new List<OrderItem>();
        for (int c = 0; c < 10; c++)
        {
            OrderItem item = new OrderItem();
            item.Price = (c + 1) * 30;
            Product product = new Product();
            product.ListPrice = (c + 1) * 32;
            product.Name = "Product " + (c + 1);
            item.Product = product;
            item.Quantity = 1;
            orderItems.Add(item);
        }

        salesOrder.OrderItems = orderItems;
        Console.WriteLine("Total orden: " + salesOrder.GetTotal());
        try
        {
            AbstractOrderValidator validator = OrderValidatorBuilder.BuildSalesOrderValidator();
            validator.Validate(salesOrder);
            Console.WriteLine("Validation exitosa.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        
    }
}