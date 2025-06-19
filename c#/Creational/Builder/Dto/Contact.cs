namespace Dto.Contact
{
    public class ContactDto
    {
        private string name;
        private string phone;

        public ContactDto(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public override string ToString()
        {
            return $"{name} - {phone}";
        }
    }
}