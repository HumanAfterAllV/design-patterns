from abc import ABC, abstractmethod
from typing import List

# Clase abstracta
class AbstractProduct(ABC):
    @abstractmethod
    def __init__(self, name: str, price: float):
        self._name = name
        self._price = price
    
    def get_name(self) -> str:
        return self._name

    def set_name(self, name: str):
        self._name = name

    def get_price(self) -> float:
        return self._price

    def set_price(self, price: float):
        self._price = price

# Producto simple
class SimpleProduct(AbstractProduct):
    def __init__(self, name: str, price: float, brand: str):
        super().__init__(name, price)
        self.brand = brand
    
    def get_brand(self) -> str:
        return self.brand
    
    def set_brand(self, brand: str):
        self.brand = brand


# Clase Compuesta de otros productos
class CompositeProduct(AbstractProduct):
    def __init__(self, name: str):
        super().__init__(name, 0.0)
        self.products: List[AbstractProduct] = []  # Lista de productos hijos

    def get_price(self) -> float:
        total_price = 0.0
        for product in self.products:
            total_price += product.get_price()
        return total_price

    def set_price(self, price: float):
        raise NotImplementedError("Setting price is not supported for CompositeProduct")

    def add_product(self, product: AbstractProduct):
        self.products.append(product)

    def remove_product(self, product: AbstractProduct) -> bool:
        if product in self.products:
            self.products.remove(product)
            return True
        return False