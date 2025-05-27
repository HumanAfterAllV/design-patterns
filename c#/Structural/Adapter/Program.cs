using Adapter;

var legacy = new LegacyPaymentGateway();
var paymentData = new PaymentData { Total = 100, CurrencyCode = "USD" };
var response = legacy.MakePayment(paymentData);

Console.WriteLine(response.Status);

