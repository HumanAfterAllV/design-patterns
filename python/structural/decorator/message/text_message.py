from message.message import IMessage

class TextMessage(IMessage):
    def __init__(self, content: str):
        self.content = content

    def process_message(self) -> 'IMessage':
        return self
    
    def get_content(self) -> str:
        return self.content
    
    def set_content(self, content: str):
        self.content = content
    
        
