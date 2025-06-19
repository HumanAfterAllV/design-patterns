namespace Interface.IPaymentProcessor
{
    public interface IPaymentProcessor
    {
        bool Pay(float amount, string currency);
    }
}