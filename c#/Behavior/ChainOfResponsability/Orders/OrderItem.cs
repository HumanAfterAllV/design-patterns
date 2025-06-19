using Models;

namespace Orders
{
    public class OrderItem
    {
        public Product? Product { get; set; }
        public double Price { get; set; }
        public float Quantity { get; set; }

        public double GetTotal()
        {
            return Price * Quantity;
        }
    }
}