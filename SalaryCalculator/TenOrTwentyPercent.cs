namespace SalaryCalculator
{
    public class TenOrTwentyPercent : CalculationRule
    {
        protected override double BasePercentage()
        {
            return 0.9;
        }

        protected override int Limit()
        {
            return 3000;
        }

        protected override double PercentageAboveTheLimit()
        {
            return 0.8;
        }
    }
}
