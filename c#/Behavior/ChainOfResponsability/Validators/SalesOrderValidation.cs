using System.ComponentModel.DataAnnotations;
using Orders;

namespace Validators
{
    public class SalesOrderValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            if (!(order.GetType() == typeof(SalesOrder)))
            {
                throw new ValidationException("Se esperaba una orden de venta");
            }

            foreach (AbstractOrderValidator validator in Validators)
            {
                validator.Validate(order);
            }
        }
    }
}