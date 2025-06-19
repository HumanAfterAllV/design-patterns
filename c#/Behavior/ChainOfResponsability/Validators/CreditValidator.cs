using System.ComponentModel.DataAnnotations;
using Models;
using Orders;

namespace Validators
{
    public class CreditValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            double total = order.GetTotal();

            if (order.Contributor == null)
            {
                throw new ArgumentNullException(nameof(order.Contributor), "El contribuyente es nulo/vacío.");
            }
            if (order.Contributor.CreditData == null)
            {
                throw new ArgumentNullException(nameof(order.Contributor.CreditData), "El valor del crédito es nulo/vacío.");
            }
            CreditData creditData = order.Contributor.CreditData;
            double newBalance = creditData.Balance + total;

            if (newBalance > creditData.CreditLimit)
            {
                throw new ValidationException("La cantidad de la orden excede el limite de crédito permitido.");
            }

        }
    }
}