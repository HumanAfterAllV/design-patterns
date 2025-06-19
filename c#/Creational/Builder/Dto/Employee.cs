using Dto.Address;
using Dto.Contact;
using Dto.Phone;

namespace Dto.Employee
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public class EmployeeDto
    {
        private string name;
        private int age;
        private Gender gender;
        private AddressDto address;
        private List<PhoneDto> phones = new List<PhoneDto>();
        private List<ContactDto> contacts = new List<ContactDto>();

        public EmployeeDto(string name, int age, Gender gender, AddressDto address, List<PhoneDto> phones, List<ContactDto> contacts)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.phones = phones;
            this.contacts = contacts;
        }

        public override string ToString()
        {
            var phonesStr = string.Join(", ", phones.Select(p => p.ToString()));
            var contactsStr = string.Join(", ", contacts.Select(c => c.ToString()));
            return $"Employee \n Name: {name} \n Age: {age} \n Gender: {gender} \n Address: {address} \n Phones: {phonesStr} \n Contacts: {contactsStr}";
        }

    }
}