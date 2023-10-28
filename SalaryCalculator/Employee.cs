namespace SalaryCalculator
{
    public class Employee
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }
        public Role Role { get; private set; }

        public Employee(string name, double salary, Role role)
        { 
            Name = name;
            Salary = salary;
            Role = role;
        }
    }
}
