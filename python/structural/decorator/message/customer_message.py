from message.message import IMessage


class CustomerMessage(IMessage):
    def __init__(self, name: str, email: str, telephone: int):
        self.name = name
        self.email = email
        self.telephone = telephone

    def processMessage(self) -> 'IMessage':
        return self
    
    def to_string(self) -> str:
        return print(f"Name: {self.name} Email: {self.email} Telephone: {self.telephone}")

    def get_content(self) -> str:
        return self.to_string();

    def set_content(self):
        raise NotImplementedError("Not supported yet.")
    
    

    
        