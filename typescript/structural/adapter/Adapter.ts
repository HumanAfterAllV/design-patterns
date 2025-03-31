interface PaymentProcesor {
    Pay(amount: number, currency: string): boolean;
};

class LegacyPaymentGateway {
    makePayment(data: {total: number, currency_code: string}): { status: string, transaction_id: string} {
        console.log("[Legacy] Processing data: " , data)
        return {
            status : "success",
            transaction_id: "abc123"
        };
    };
};

class PaymentAdapter implements PaymentProcesor {
    private legacyGateway : LegacyPaymentGateway;

    constructor(legacyGateway: LegacyPaymentGateway) {
        this.legacyGateway = legacyGateway;
    };

    Pay(amount: number, currency: string): boolean {
        const data = {
            total : amount,
            currency_code: currency,
        };

        const response = this.legacyGateway.makePayment(data)
        return response.status === "success"
    }
};

export { PaymentAdapter, LegacyPaymentGateway, PaymentProcesor };