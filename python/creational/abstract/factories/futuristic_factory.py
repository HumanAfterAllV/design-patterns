from factories.base_factory import GameWorldFactory
from products.base_enemy import RobotSoldier
from products.base_weapon import PlasmaGun
from products.base_environment import SpaceStation


class FuturisticFactory(GameWorldFactory):
    
    def create_enemy(self):
        return RobotSoldier()

    def create_environment(self):
        return SpaceStation()
    
    def create_weapon(self):
        return PlasmaGun()
