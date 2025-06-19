namespace Dto.Address
{
    public class AddressDto
    {
        private readonly string city;
        private readonly string country;
        private readonly string cp;
        private readonly string addr;

        public AddressDto(string city, string country, string cp, string addr)
        {
            this.city = city;
            this.country = country;
            this.cp = cp;
            this.addr = addr;
        }

        public override string ToString()
        {
            return $"{addr} - {city} - {cp} - {country}";
        }
        
    }
}