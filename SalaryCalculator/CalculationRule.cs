namespace SalaryCalculator
{
    public abstract class CalculationRule
    {
        public double Calculate (Employee employee)
        {
            if (employee.Salary > Limit())
            {
                return employee.Salary * PercentageAboveTheLimit();
            }
            return employee.Salary * BasePercentage();
        }

        protected abstract int Limit();

        protected abstract double PercentageAboveTheLimit();

        protected abstract double BasePercentage();
    }
}
