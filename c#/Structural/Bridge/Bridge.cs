
using Interface.ITransmission;

namespace Bridge
{
    public class Bluetooth : ITransmission
    {
        public void Transmit(string data)
        {
            Console.WriteLine($"🔵 Sending via Bluetooth: {data}");
        }
    }

    public class Cable : ITransmission
    {
        public void Transmit(string data)
        {
            Console.WriteLine($"🔌 Sending via Cable: {data}");
        }
    }

    public class Wifi : ITransmission
    {
        public void Transmit(string data)
        {
            Console.WriteLine($"📡 Sending via Wifi: {data}");
        }
    }

    public abstract class AudioDevice
    {
        protected ITransmission transmission;

        protected AudioDevice(ITransmission transmission)
        {
            this.transmission = transmission;
        }

        protected void Transmit(string data)
        {
            transmission.Transmit(data);
        }
    }

    public class HeadPhones : AudioDevice
    {
        public HeadPhones(ITransmission transmission) : base(transmission)
        {
        }
        public void PlaySound(string sound)
        {
            Console.WriteLine($"🎧 Headphones playing...");
            this.Transmit(sound);
        }
    }

    public class Speaker : AudioDevice
    {
        public Speaker(ITransmission transmission) : base(transmission)
        {
        }
        public void PlaySound(string sound)
        {
            Console.WriteLine("🔊 Speaker playing...");
            this.Transmit(sound);
        }   
    }

}
