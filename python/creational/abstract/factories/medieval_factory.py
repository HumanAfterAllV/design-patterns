from factories.base_factory import GameWorldFactory
from products.base_enemy import Orc
from products.base_weapon import Sword
from products.base_environment import Cave

class MedievalFactory(GameWorldFactory):
    
    def create_enemy(self):
        return Orc()

    def create_environment(self):
        return Cave()

    def create_weapon(self):
        return Sword()