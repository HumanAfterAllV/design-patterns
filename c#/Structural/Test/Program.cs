using System;
using Adapter.LegacyPaymentGateway;
using Adapter.PaymentResponse;

class Program
{
    static void Main(string[] args)
    {
        var legacy = new LegacyPaymentGateway();
        var payment = new PaymentAdapter(legacy);

        bool result = payment.Pay(100, "USD");

        if (result)
            Console.WriteLine("✅ Payment successful");
        else
            Console.WriteLine("❌ Payment failed");
    }
}