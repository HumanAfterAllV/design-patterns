using Models;

namespace Orders
{
    public abstract class AbstractOrder
    {
        public DateTime? CreateDate { get; set; }
        public Contributor? Contributor { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public double GetTotal()
        {
            double total = 0d;

            foreach (OrderItem abstractOrderItem in OrderItems)
            {
                total += abstractOrderItem.GetTotal();
            }

            return total;

        }
    }
}