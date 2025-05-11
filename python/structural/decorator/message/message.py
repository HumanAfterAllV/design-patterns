from abc import ABC,abstractmethod

class IMessage(ABC):
    @abstractmethod
    def process_message(self) ->'IMessage':
        pass
    
    @abstractmethod
    def get_content(self) -> str:
        pass

    @abstractmethod
    def set_content(self, content: str):
        pass

