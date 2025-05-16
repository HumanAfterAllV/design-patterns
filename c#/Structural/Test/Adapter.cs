using interface.IPaymentProcessor;

public class PaymentData
{
    public float Total { get; set; }
    public string CurrencyCode { get; set; }
}

public class PaymentResponse
{
    public string Status { get; set; }
}
public class LegacyPaymentGateway
{
    public PaymentResponse MakePayment(PaymentData data)
    {
        Console.WriteLine("[Legacy] Processing data: Total={0}, CurrencyCode={1}", data)
        return new PaymentResponse
        {
            Status = "success",
            TransactionId = "abc123"
        }
    }
}