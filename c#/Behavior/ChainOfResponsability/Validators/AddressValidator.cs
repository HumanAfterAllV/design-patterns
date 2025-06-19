using System.ComponentModel.DataAnnotations;
using Models;
using Orders;

namespace Validators
{
    public class AddressValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            if (order.Contributor == null || order.Contributor.Address == null)
            {
                throw new ArgumentNullException("Contribuidor o dirección son nulos/vacíos.");
            }

            Address address = order.Contributor.Address;

            if (address.Address1 == null || address.Address1.Length == 0)
            {
                throw new ValidationException("La dirección es obligatoria");
            }
            else if (address.CP == null || address.CP.Length != 4)
            {
                throw new ValidationException("CP debe tener solamente 4 caracteres");
            }
            else if (address.Country == null || address.Country.Length == 0)
            {
                throw new ValidationException("El país es obligatorio");
            }
            
        }
    }
}