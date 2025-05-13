class Icon:
    def __init__(self, type: str, image_path: str):
        self.type = type               
        self.image_path = image_path    

    def render(self, latitude: float, longitude: float):
        print(f"📍 Render '{self.type.upper()}' at ({latitude}, {longitude}) using image: {self.image_path}")
