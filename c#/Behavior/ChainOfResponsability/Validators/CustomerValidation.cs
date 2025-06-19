using System.ComponentModel.DataAnnotations;
using Models;
using Orders;

namespace Validators
{
    public class CustomerValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            foreach (AbstractOrderValidator validator in Validators)
            {
                validator.Validate(order);
            }

            if (order.Contributor == null)
            {
                throw new ArgumentNullException("El contribuyente es nulo/vacío.");
            }
            if (!(order.Contributor.GetType() == typeof(Customer)))
            {
                throw new ValidationException("El contribuyente no es un cliente");
            }
        }
    }
}