namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.Role.CalculationRule.Calculate(employee);
        }

    }
}
