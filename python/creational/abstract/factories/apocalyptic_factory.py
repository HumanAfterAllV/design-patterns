from factories.base_factory import GameWorldFactory
from products.base_enemy import Mutant
from products.base_weapon import Claws
from products.base_environment import City

class ApocalypticFactory(GameWorldFactory):
    
    def create_enemy(self):
        return Mutant()

    def create_environment(self):
        return City()

    def create_weapon(self):
        return Claws()