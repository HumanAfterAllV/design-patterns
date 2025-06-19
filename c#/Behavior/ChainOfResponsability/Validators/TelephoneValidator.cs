using System.ComponentModel.DataAnnotations;
using Models;
using Orders;

namespace Validators
{
    public class TelephoneValidator : AbstractOrderValidator
    {
        public override void Validate(AbstractOrder order)
        {
            if (order.Contributor == null || order.Contributor.Telephone == null)
            {
                throw new ArgumentNullException("El contribuyente/teléfono tiene un valor nulo/vacío.");
            }

            Telephone tel = order.Contributor.Telephone;

            if (tel.Number == null)
            {
                throw new ValidationException("Se necesita teléfono del contribuyente.");
            }

            if (tel.Lada == null)
            {
                throw new ValidationException("Se necesita una lada.");
            }

            if (null == tel)
            {
                throw new ValidationException("El contribuyente/teléfono es requerido.");
            }
            else if (tel.Number.Length != 7)
            {
                throw new ValidationException("El teléfono no es valido.");
            }
            else if (tel.Lada.Length != 3)
            {
                throw new ValidationException("Lada invalida.");
            }


        }
    }
}