using System.ComponentModel.DataAnnotations;
using Models;
using Orders;

namespace Validators
{
    public class OrderItemValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            List<OrderItem> orderItems = order.OrderItems;

            foreach (OrderItem item in orderItems)
            {
                if (item.Product == null)
                {
                    throw new ValidationException("El producto no es valido.");
                }
                Product product = item.Product;

                if (item.Quantity <= 0)
                {
                    throw new ValidationException($"El producto {product.Name} no tiene una cantidad.");
                }

                double listPrice = item.Product.ListPrice;
                double price = item.Price;
                double limitPrice = listPrice - (listPrice / 0.020d);

                if (price < limitPrice)
                {
                    throw new ValidationException($"El precio del producto {product.Name} excede lo permitido de la lista");
                }
            }
        }
    }
}