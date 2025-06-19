from enum import Enum

class TypePhone(Enum):
    MOBILE = "Mobile"
    HOME = "Home"
    WORK = "Work"
    OTHER = "Other"

class Phone:
    def __init__(self, phone: int, type_phone: TypePhone):
        self.phone = phone
        self.type_phone = type_phone

    def __str__(self) -> str:
        return f"Phone: {self.phone} - {self.type_phone}"