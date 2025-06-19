from map.icon_factory import IconFactory
from map.location import MapLocation

factory = IconFactory()

loc1 = MapLocation(19.4, -99.1, factory.get_icon("hospital"), "Hospital Central")
loc2 = MapLocation(19.5, -99.2, factory.get_icon("hospital"), "Hospital del Norte")
loc3 = MapLocation(19.6, -99.3, factory.get_icon("school"), "Escuela Técnica")

loc1.draw()
loc2.draw()
loc3.draw()
