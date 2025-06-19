using Dto.Address;
using Dto.Phone;
using Dto.Contact;
using Dto.Employee;

namespace Builder.EmployeeBuilder
{
    public class EmployeeBuilderClass
    {
        private string? name = null;
        private int? age = null;
        private Gender? gender = null;
        private AddressDto? address = null;
        private List<PhoneDto> phones = new List<PhoneDto>();
        private List<ContactDto> contacts = new List<ContactDto>();


        public EmployeeBuilderClass SetName(string name)
        {
            this.name = name;
            return this;
        }

        public EmployeeBuilderClass SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public EmployeeBuilderClass SetGender(Gender gender)
        {
            this.gender = gender;
            return this;
        }

        public EmployeeBuilderClass SetAddress(string addr, string city, string country, string cp)
        {
            address = new AddressDto(city, country, cp, addr);
            return this;
        }

        public EmployeeBuilderClass AddPhone(string phoneNumber, TypePhone phoneType)
        {
            phones.Add(new PhoneDto(phoneNumber, phoneType));
            return this;
        }
        
        public EmployeeBuilderClass AddContact(string name, string phoneNumber)
        {
            contacts.Add(new ContactDto(name, phoneNumber));
            return this;
        }

        public EmployeeDto Build()
        {
            if (string.IsNullOrEmpty(name) || !age.HasValue || !gender.HasValue || address == null)
            {
                throw new InvalidOperationException("Missing required fields to build Employee");
            }
            return new EmployeeDto(name, age.Value, gender.Value, address, phones, contacts);
        }
    }
}