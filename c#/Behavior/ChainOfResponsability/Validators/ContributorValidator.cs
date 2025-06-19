using System.ComponentModel.DataAnnotations;
using Models;
using Orders;

namespace Validators
{
    public class ContributorValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            foreach (AbstractOrderValidator validator in Validators)
            {
                validator.Validate(order);
            }

            if (order.Contributor == null)
            {
                throw new ArgumentNullException("Contribuidor es nulo/vacío.");
            }
            Contributor contributor = order.Contributor;

            if (Status.ACTIVO != contributor.Status)
            {
                throw new ValidationException("El contribuyente no esta activo.");
            }

        }
    }
}