from map.icon import Icon

class MapLocation:
    def __init__(self, lat: float, long: float, icon: Icon, name: str):
        self.lat = lat
        self.long = long
        self.icon = icon
        self.name = name

    def draw(self):
        print(f"📌 {self.name}")
        Icon.render(self.icon, self.lat, self.long)
        