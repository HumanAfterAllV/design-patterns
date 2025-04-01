from abc import ABC, abstractmethod

# Interfaz esperada 
class Transmission(ABC):
    @abstractmethod
    def transmit(self, data: str) -> None:
        pass

# Implementaciones concretas
class Bluetooth(Transmission):
    def transmit(self, data: str) -> None:
        print(f"🔵 Sending via Bluetooth: {data}")

class Cable(Transmission):
    def transmit(self, data: str) -> None:
        print(f"🔌 Sending via Cable: {data}")

class Wifi(Transmission):
    def transmit(self, data: str) -> None:
        print(f"📡 Sending via Wifi: {data}")

# Abstracción
class AudioDevice(ABC):
    def __init__(self, transmission: Transmission):
        self.transmission = transmission

    @abstractmethod
    def play_sound(self, sound: str) -> None:
        pass

# Dispositivos concretos
class Headphones(AudioDevice):
    def play_sound(self, sound: str) -> None:
        print("🎧 Headphones playing...")
        self.transmission.transmit(sound)

class Speaker(AudioDevice):
    def play_sound(self, sound: str) -> None:
        print("🔊 Speaker playing...")
        self.transmission.transmit(sound)

