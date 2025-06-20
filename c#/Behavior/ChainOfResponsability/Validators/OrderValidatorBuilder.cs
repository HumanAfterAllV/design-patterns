namespace Validators
{
    public class OrderValidatorBuilder
    {
        public static AbstractOrderValidator BuildSalesOrderValidator()
        {
            AbstractOrderValidator validator = new SalesOrderValidator();
            validator.AddValidator(BuildCustomerValidator());
            validator.AddValidator(new OrderItemValidator());
            validator.AddValidator(new CreditValidator());

            return validator;
        }

        private static AbstractOrderValidator BuildCustomerValidator()
        {
            AbstractOrderValidator validator = new CustomerValidator();
            validator.AddValidator(new CustomerValidator());
            return validator;
        }

        private static AbstractOrderValidator BuildContributorValidator()
        {
            AbstractOrderValidator validator = new ContributorValidator();
            validator.AddValidator(new AddressValidator());
            validator.AddValidator(new TelephoneValidator());

            return validator;
        }
    }
}