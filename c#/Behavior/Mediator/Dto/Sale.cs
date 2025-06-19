namespace Dto
{
    public class Sale
    {
        public List<Product> Products { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}