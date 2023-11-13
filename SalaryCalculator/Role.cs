namespace SalaryCalculator
{
    public class Role
    {
        public static Role DEVELOPER { get { return new Role(new TenOrTwentyPercent()); } }
        public static Role DBA { get { return new Role(new FifteenOrTwentyFivePercent()); } }
        public static Role TESTER { get { return new Role(new FifteenOrTwentyFivePercent()); } }

        public CalculationRule CalculationRule { get; private set; }

        private Role(CalculationRule calculationRule)
        {
            CalculationRule = calculationRule;
        }
    }
}
