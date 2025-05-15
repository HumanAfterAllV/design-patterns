class Address:
    def __init__(self, city: str, country: str, cp: str, addr: str):
        self.city = city
        self.country = country
        self.cp = cp
        self.addr = addr
        
    def __str__(self) -> str:
        return f"Address: {self.addr} - {self.city} - {self.cp} - {self.country}"