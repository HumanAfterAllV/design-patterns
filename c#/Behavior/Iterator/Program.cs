using IteratorEmployee;
class Program
{
    static void Main()
    {
        var emp3 = new Employee("Trinity", "Developer");
        var emp4 = new Employee("Morpheus", "Architect");
        var emp2 = new Employee("Smith", "QA", emp3, emp4);
        var emp1 = new Employee("Neo", "Team Lead", emp2);

        var iterator = emp1.CreateIterator();

        while (iterator.HasNext())
        {
            var emp = iterator.Next();
            Console.WriteLine(emp);
        }
    }
}
