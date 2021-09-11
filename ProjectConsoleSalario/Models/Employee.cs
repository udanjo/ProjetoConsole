namespace ProjectConsoleSalario.Model
{
    public record Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }

        public decimal Salary { get; private set; }
    }
}