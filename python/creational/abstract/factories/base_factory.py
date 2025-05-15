from abc import ABC, abstractmethod

class GameWorldFactory(ABC):
    @abstractmethod
    def create_enemy(self) -> Enemy:
        pass

    @abstractmethod
    def create_environment(self) -> Environment:
        pass

    @abstractmethod
    def create_weapon(self) -> Weapon:
        pass