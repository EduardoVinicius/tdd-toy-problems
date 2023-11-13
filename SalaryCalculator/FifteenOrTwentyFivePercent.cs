namespace SalaryCalculator
{
    public class FifteenOrTwentyFivePercent : CalculationRule
    {
        protected override double BasePercentage()
        {
            return 0.85;
        }

        protected override int Limit()
        {
            return 2500;
        }

        protected override double PercentageAboveTheLimit()
        {
            return 0.75;
        }
    }
}
