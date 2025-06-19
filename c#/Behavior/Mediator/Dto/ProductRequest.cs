namespace Dto
{
    public class ProductRequest
    {
        public List<Product> Products;

        public ProductRequest()
        {
            this.Products = new List<Product>();
        }
    }
}