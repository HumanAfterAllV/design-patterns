from message.message import IMessage

class MessageDecorator(IMessage):
    def __init__(self, message: IMessage):
        self.message = message

    def MessageDecorator(self, message: IMessage):
        self.message = message

    def set_content(self, content: str):
        self.message.set_content(content)
    
    def get_content(self) -> str:
        return self.message.get_content()
