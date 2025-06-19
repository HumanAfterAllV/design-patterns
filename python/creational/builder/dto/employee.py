from dto.address import Address
from dto.phone import Phone
from dto.contact import Contact

from abc import ABC, abstractmethod
from enum import Enum
from typing import Generic, TypeVar, List

T = TypeVar("T")

class IBuilder(ABC, Generic[T]):
    @abstractmethod
    def build(self) -> T:
        pass

class Gender(Enum):
    MALE = "Male"
    FEMALE = "Female"
    OTHER = "Other"

class Employee:
    def __init__(self, name:str, age: int, gender: Gender, address: Address, phones: List[Phone], contacts: List[Contact]):
        self.name = name
        self.age = age
        self.gender = gender
        self.address = address
        self.phones = phones if phones else []
        self.contacts = contacts if contacts else []

    def __str__(self) -> str:
        return (
            f"Employee{{name={self.name}, age={self.age}, gender={self.gender},\n"
            f"address={self.address},\n"
            f"phones={[str(phone) for phone in self.phones]},\n"
            f"contacts={[str(contact) for contact in self.contacts]}}}"
        )
        