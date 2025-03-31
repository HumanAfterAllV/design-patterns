from abc import ABC, abstractmethod
from typing import Dict

# Interfaz esperada 
class PaymentProcessor(ABC):
    @abstractmethod
    def pay(self, amount: float, currency: str) -> bool:
        pass
        
# Sistema de pagos legado
class LegacyPaymentGateway:
    def make_payment(self, data: Dict[str, object]) -> Dict[str, str]:
        print(f"[Legacy] Processing payment: {data}")
        return {
            "status": "success",
            "transaction_id": "abc123"
        }
    
# Clase Adapter    
class PaymentAdapter(PaymentProcessor):
    def __init__(self, legacy_gateway: LegacyPaymentGateway) -> None:
        self.legacy_gateway = legacy_gateway

    def pay(self, amount: float, currency: str) -> bool:
        data = {
            "total": amount,
            "currency_code": currency
        }
        response = self.legacy_gateway.make_payment(data)
        return response.get("status") == "success"