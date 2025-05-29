using Builder.EmployeeBuilder;
using Dto.Employee;
using Dto.Phone;


public class Program
{
    static void Main()
    {

        var employee = new EmployeeBuilderClass()
            .SetName("Neo")
            .SetAge(30)
            .SetGender(Gender.Male)
            .SetAddress("Calle 1", "New York", "EU", "12345")
            .AddPhone("555-1234", TypePhone.Mobile)
            .AddContact("Trinity", "555-5678")
            .Build();

        Console.WriteLine(employee);
    }
}
    
