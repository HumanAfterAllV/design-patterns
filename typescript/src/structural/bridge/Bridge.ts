// Interfaz
interface Transmission {
    transmit(data: string): void;
}
  
// Implementaciones concretas
class Bluetooth implements Transmission {
    transmit(data: string): void {
        console.log(`🔵 Sending via Bluetooth: ${data}`);
    }
}
  
class Cable implements Transmission {
    transmit(data: string): void {
        console.log(`🔌 Sending via Cable: ${data}`);
    }
}
  
class Wifi implements Transmission {
    transmit(data: string): void {
        console.log(`📡 Sending via Wifi: ${data}`);
    }
}
  
  // Abstracción
class AudioDevice {
    protected transmission: Transmission;
  
    constructor(transmission: Transmission) {
        this.transmission = transmission;
    }
  
    protected transmit(data: string): void {
        this.transmission.transmit(data);
    }
}
  
  // Dispositivos concretos
class HeadPhones extends AudioDevice {
    playSound(sound: string): void {
        console.log("🎧 Headphones playing...");
        this.transmit(sound);
    }
}
  
class Speaker extends AudioDevice {
    playSound(sound: string): void {
        console.log("🔊 Speaker playing...");
        this.transmit(sound);
    }
}
  
export { Bluetooth, Wifi, HeadPhones, Speaker };
  