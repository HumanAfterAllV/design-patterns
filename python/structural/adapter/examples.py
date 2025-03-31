from adapter import LegacyPaymentGateway, PaymentAdapter

def main():
    legacy = LegacyPaymentGateway()
    adapter = PaymentAdapter(legacy)

    if adapter.pay(100.0, "USD"):
        print("✅ Payment successful")
    else:
        print("❌ Payment failed")

if __name__ == "__main__":
    main()
