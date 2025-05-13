from map.icon import Icon

class IconFactory:
    _instance = None
    _icons: dict = {}

    def __new__(cls):
        if not cls._instance:
            cls._instance = super().__new__(cls)
        return cls._instance
    
    def get_icon(self, icon_type: str) -> Icon:
        if icon_type not in self._icons:
            print(f"🆕 Creating new icon for: {icon_type}")
            path = f"/icons/{icon_type}.png"
            self._icons[icon_type] = Icon(icon_type, path)
        else:
            print(f"✅ Reusing icon for: {icon_type}")

        return self._icons[icon_type]
    