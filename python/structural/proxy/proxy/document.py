from abc import ABC, abstractmethod
import time

class Document(ABC):
    @abstractmethod
    def display(self, user: str):
        pass


class RealDocument(Document):
    def __init__(self, filename: str):
        self.filename = filename
        self.content = None

    def load_from_disk(self):
        print(f"📄 Load {self.filename} document from disk...")
        time.sleep(3)
        self.content = f"Contenido {self.content}"

    def display(self, user: str):
        if not self.content:
            self.load_from_disk()
        print(f"{user} is watching document: {self.filename}")
