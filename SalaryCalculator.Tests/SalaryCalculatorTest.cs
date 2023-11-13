namespace SalaryCalculator.Tests
{
    [TestFixture]
    public class SalaryCalculatorTest
    {
        [Test]
        public void ShouldCalculateDeveloperSalaryWithSalaryLowerThanTheLimit()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Employee developer = new Employee("Eduardo", 1500.0, Role.DEVELOPER);

            double salary = calculator.CalculateSalary(developer);

            Assert.That(salary, Is.EqualTo(1500.0 * 0.9).Within(0.00001));
        }

        [Test]
        public void ShouldCalculateDeveloperSalaryWithSalaryAboveTheLimit()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Employee developer = new Employee("Eduardo", 4000.0, Role.DEVELOPER);

            double salary = calculator.CalculateSalary(developer);

            Assert.That(salary, Is.EqualTo(4000.0 * 0.8).Within(0.00001));
        }

        [Test]
        public void ShouldCalculateDBASalaryWithSalaryLowerThanTheLimit()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Employee dba = new Employee("Eduardo", 1500.0, Role.DBA);

            double salary = calculator.CalculateSalary(dba);

            Assert.That(salary, Is.EqualTo(1500.0 * 0.85).Within(0.00001));
        }

        [Test]
        public void ShouldCalculateDBASalaryWithSalaryAboveTheLimit()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Employee dba = new Employee("Eduardo", 4500.0, Role.DBA);

            double salary = calculator.CalculateSalary(dba);

            Assert.That(salary, Is.EqualTo(4500.0 * 0.75).Within(0.00001));
        }

        [Test]
        public void ShouldCalculateTesterSalaryWithSalaryLowerThanTheLimit()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Employee tester = new Employee("Eduardo", 1500.0, Role.TESTER);

            double salary = calculator.CalculateSalary(tester);

            Assert.That(salary, Is.EqualTo(1500.0 * 0.85).Within(0.00001));
        }

        [Test]
        public void ShouldCalculateTesterSalaryWithSalaryAboveTheLimit()
        {
            SalaryCalculator calculator = new SalaryCalculator();
            Employee tester = new Employee("Eduardo", 4500.0, Role.TESTER);

            double salary = calculator.CalculateSalary(tester);

            Assert.That(salary, Is.EqualTo(4500.0 * 0.75).Within(0.00001));
        }
    }
}