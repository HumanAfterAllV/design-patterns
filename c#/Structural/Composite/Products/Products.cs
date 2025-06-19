using System.Collections.Generic;

namespace Products
{
    public abstract class AbstractProduct
    {
        protected string name;
        protected float price;

        protected AbstractProduct(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract string GetName();
        public abstract void SetName(string name);
        public abstract float GetPrice();
        public abstract void SetPrice(float price);
    }

    public class SimpleProduct : AbstractProduct
    {
        private string brand;

        public SimpleProduct(string name, float price, string brand)
            : base(name, price)
        {
            this.brand = brand;
        }

        public override string GetName()
        {
            return name;
        }

        public override void SetName(string name)
        {
            this.name = name;
        }

        public override float GetPrice()
        {
            return price;
        }

        public override void SetPrice(float price)
        {
            this.price = price;
        }

    }

    public class CompositeProducts : AbstractProduct
    {
        protected List<AbstractProduct> products = new List<AbstractProduct>();

        public CompositeProducts(string name) : base(name, 0.0f)
        {
        }  

        public override string GetName()
        {
            return this.name;
        }

        public override void SetName(string name)
        {
            this.name = name;
        }

        public override float GetPrice()
        {
            float totalPrice = 0.0f;

            foreach (var product in this.products)
            {
                totalPrice += product.GetPrice();
            }
            return totalPrice;
        }

        public override void SetPrice(float price)
        {
            throw new Exception("Setting price is not supported for Composite Product.");
        }

        public void AddProduct(AbstractProduct product)
        {
            this.products.Add(product);
        }

        public bool RemoveProduct(AbstractProduct product)
        {
            return this.products.Remove(product);
        }
    }   
}

