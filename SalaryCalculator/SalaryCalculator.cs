namespace SalaryCalculator
{
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            if (employee.Role.Equals(Role.DEVELOPER))
            {
                if (employee.Salary > 3000)
                    return 3200.0; 
                return 1350.0;
            }
            return 425.0;
        }
    }
}
