from products.products import AbstractProduct

from typing import List
from decimal import Decimal


#Orden de productos, donde vemos si son compuestos o productos simples
class Order():
    def __init__(self, order_id: int, customer: str):
        self.order_id = order_id
        self.customer = customer
        self.products : List[AbstractProduct] = []

    def get_price(self) -> float:
        total_price = 0.0
        for product in self.products:
            total_price += product.get_price()
        return total_price
        

    def add_product(self, product: AbstractProduct):
        self.products.append(product)

    def print_order(self):
        print("\n=============================================")
        print(f"Order: {self.order_id}")
        print(f"Customer: {self.customer}")
        print("Products:\n")
        for product in self.products:
            print(f"{product.get_name()}\t\t\t$ {Decimal(product.get_price()):,.2f}")
        print(f"Total: {Decimal(self.get_price()):,.2f}")
        print("=============================================")

    def get_order_id(self) -> int:
        return self.order_id
    
    def set_order_id(self, order_id: int):
        self.order_id = order_id

    def get_customer(self) -> str:
        return self.customer

    def set_customer(self, customer: str):
        self.customer = customer

    def get_products(self) -> List[AbstractProduct]:
        return self.products

    def set_products(self, products: List[AbstractProduct]):
        self.products = products