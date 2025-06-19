using Products;
using System.Collections.Generic;

namespace Orders
{
    public class Order
    {
        protected int orderId;
        protected string customer;
        protected List<AbstractProduct> products = new List<AbstractProduct>();

        public Order(int orderId, string customer)
        {
            this.orderId = orderId;
            this.customer = customer;
        }

        public float GetPrice()
        {
            float totalPrice = 0.0f;
            foreach (var product in this.products)
            {
                totalPrice += product.GetPrice();
            }
            return totalPrice;
        }

        public void AddProduct(AbstractProduct product)
        {
            this.products.Add(product);
        }

        public void PrintOrder()
        {
            Console.WriteLine("\n=============================================");
            Console.WriteLine($"Order: {this.orderId}");
            Console.WriteLine($"Customer: {this.customer}");
            Console.WriteLine($"Products: \n");
            foreach (var product in this.products)
            {
                Console.WriteLine($"{product.GetName()} \t\t\t {product.GetPrice()}");
            }
            Console.WriteLine($"Total: {this.GetPrice()}");
        }

        public int GetOrderId()
        {
            return this.orderId;
        }
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        public string GetCustomer()
        {
            return this.customer;
        }

        public void SetCustomer(string customer)
        {
            this.customer = customer;
        }

        public List<AbstractProduct> GetProducts()
        {
            return this.products;
        }

        public void SetProducts(List<AbstractProduct> products)
        {
            this.products = products;
        }
    }
}