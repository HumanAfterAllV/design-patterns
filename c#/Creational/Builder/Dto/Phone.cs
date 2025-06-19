namespace Dto.Phone
{

    public enum TypePhone
    {
        Mobile,
        Home,
        Work,
        Other
    }
    public class PhoneDto
    {
        private string phoneNumber;
        private TypePhone typePhone;

        public PhoneDto(string phoneNumber, TypePhone typePhone)
        {
            this.phoneNumber = phoneNumber;
            this.typePhone = typePhone;
        }

        public override string ToString()
        {
            return $"{phoneNumber} - {typePhone}";
        }
    }
}