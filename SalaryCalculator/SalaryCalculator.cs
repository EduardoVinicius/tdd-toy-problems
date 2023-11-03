namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            if (employee.Salary > 3000)
            {
                return employee.Salary * 0.8;
            }
            return employee.Salary * 0.9;
        }
    }
}
