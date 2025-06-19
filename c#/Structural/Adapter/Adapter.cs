namespace Adapter
{
    public class PaymentData
    {
        public float Total { get; set; }
        public required string CurrencyCode { get; set; }
    }
    public class PaymentResponse
    {
        public required string Status { get; set; }
        public required string TransactionId { get; set; }
    }

    public class LegacyPaymentGateway
    {
        public PaymentResponse MakePayment(PaymentData data)
        {
            Console.WriteLine("[Legacy] Processing data Total={0}, CurrencyCode={1}", data.Total, data.CurrencyCode);
            return new PaymentResponse
            {
                Status = "Success",
                TransactionId = "abc123"
            };
        }
    }
}