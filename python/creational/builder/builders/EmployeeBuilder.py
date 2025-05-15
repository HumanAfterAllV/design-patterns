from dto.address import Address
from dto.phone import Phone,TypePhone
from dto.contact import Contact
from dto.employee import Employee, Gender

class EmployeeBuilder:
    def __init__(self):
        self.name = None
        self.age = None
        self.gender = None
        self.address = None
        self.phones = []
        self.contacts = []

    def set_name(self, name: str):
        self.name = name
        return self

    def set_age(self, age: int):
        self.age = age
        return self

    def set_gender(self, gender: Gender):
        self.gender = gender
        return self

    def set_address(self, addr: str, city: str, country: str, cp: str):
        self.address = Address(city, country, cp, addr)
        return self

    def add_phone(self, phone_number: str, phone_type: TypePhone):
        self.phones.append(Phone(phone_number, phone_type))
        return self

    def add_contact(self, name: str, phone_number: int,  ):
        self.contacts.append(Contact(name, phone_number))
        return self

    def build(self) -> Employee:
        return Employee(self.name, self.age, self.gender, self.address, self.phones, self.contacts)