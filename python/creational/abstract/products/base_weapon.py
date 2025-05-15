from abc import ABC, abstractmethod

class Weapon(ABC):
    @abstractmethod
    def damage(self):
        pass


class PlasmaGun(Weapon):
    def damage(self) -> str:
        print("⚡: 100 dm")

class Sword(Weapon):
    def damage(self) -> str:
        print("🗡️ : 50 dm")

class Claws(Weapon):
    def damage(self) -> str:
        print("💀 : 25 dm")