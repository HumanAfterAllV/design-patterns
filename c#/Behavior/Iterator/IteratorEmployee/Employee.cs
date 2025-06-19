namespace IteratorEmployee
{
    public interface IContainer<T>
    {
        IIterator<T> CreateIterator();
    }

    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public class Employee : IContainer<Employee>
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<Employee> Subordinates { get; set; } = new List<Employee>();

        public Employee(string name, string role, params Employee[] subordinates)
        {
            Name = name;
            Role = role;
            if (subordinates != null)
                Subordinates = subordinates.ToList();
        }

        public IIterator<Employee> CreateIterator()
        {
            return new TreeEmployeeIterator(this);
        }

        public void AddSubordinate(Employee subordinate)
        {
            if (subordinate != null)
                Subordinates.Add(subordinate);
        }

        public override string ToString()
        {
            return $"Employee{{name={Name}, role={Role}}}";
        }

        private class TreeEmployeeIterator : IIterator<Employee>
        {
            private readonly List<Employee> _list = new List<Employee>();
            private int _index = 0;

            public TreeEmployeeIterator(Employee root)
            {
                AddRecursive(root);
            }

            private void AddRecursive(Employee employee)
            {
                _list.Add(employee);
                if (employee.Subordinates != null)
                {
                    foreach (var subordinate in employee.Subordinates)
                    {
                        AddRecursive(subordinate);
                    }
                }
            }

            public bool HasNext()
            {
                return _index < _list.Count;
            }

            public Employee Next()
            {
                if (!HasNext())
                    throw new InvalidOperationException("There are no more elements.");
                return _list[_index++];
            }
        }
    }
}