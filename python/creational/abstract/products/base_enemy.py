from abc import ABC, abstractmethod

class Enemy(ABC):
    @abstractmethod
    def attack(self):
        pass


class RobotSoldier(Enemy):
    def attack(self) -> str:
        print("⚡ Fire laser beams")

class Orc(Enemy):
    def attack(self) -> str:
        print("🗡️ Sword attack")

class Mutant(Enemy):
    def attack(self) -> str:
        print("💀 Acid lance")

