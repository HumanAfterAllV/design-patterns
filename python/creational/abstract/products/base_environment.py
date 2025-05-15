from abc import ABC, abstractmethod

class Environment(ABC):
    @abstractmethod
    def difficulty(self):
        pass


class SpaceStation(Environment):
    def difficulty(self) -> str:
        print("Hard")

class Cave(Environment):
    def difficulty(self) -> str:
        print("Medium")

class City(Environment):
    def difficulty(self) -> str:
        print("Easy")