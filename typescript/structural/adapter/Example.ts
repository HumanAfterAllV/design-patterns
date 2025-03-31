import { LegacyPaymentGateway, PaymentAdapter, PaymentProcesor } from "./Adapter";

const legacy = new LegacyPaymentGateway();
const payment = new PaymentAdapter(legacy);

const result = payment.Pay(100, "USD");

result ? console.log("✅ Payment successful") : console.log("❌ Payment failed")
