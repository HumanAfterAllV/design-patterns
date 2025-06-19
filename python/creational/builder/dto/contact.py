class Contact: 
    def __init__(self, name: str, phone: int):
        self.name = name
        self.phone = phone
    
    def __str__(self) -> str:
        return f"Contact: {self.name} - {self.phone}"