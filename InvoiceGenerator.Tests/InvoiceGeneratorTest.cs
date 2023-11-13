using Moq;
using System;

namespace InvoiceGenerator.Tests
{
    [TestFixture]
    public class InvoiceGeneratorTest
    {
        //[Test]
        //public void ShouldCallNextActions()
        //{
        //    var action1 = new Mock<IActionAfterInvoiceGeneration>();
        //    var action2 = new Mock<IActionAfterInvoiceGeneration>();

        //    IList<IActionAfterInvoiceGeneration> actions = new List<IActionAfterInvoiceGeneration>()
        //    {
        //        action1.Object, action2.Object
        //    };

        //    InvoiceGenerator generator = new InvoiceGenerator(actions);
        //    Order order = new Order("Eduardo", 1000, 1);

        //    Invoice invoice = generator.Generate(order);

        //    action1.Verify(action => action.Execute(invoice));
        //    action2.Verify(action => action.Execute(invoice));
        //}

        [Test]
        public void ShouldCheckTableToCalculateValue()
        {
            var table = new Mock<ITable>();
            table.Setup(t => t.ForValue(1000.0)).Returns(0.2);

            IList<IActionAfterInvoiceGeneration> noAction = new List<IActionAfterInvoiceGeneration>();

            InvoiceGenerator generator = new InvoiceGenerator(noAction, table.Object);
            Order order = new Order("Eduardo", 1000, 1);

            Invoice invoice = generator.Generate(order);

            table.Verify(t => t.ForValue(1000.0));
            Assert.That(invoice.Value, Is.EqualTo(1000 * 0.2).Within(0.00001));
        }
    }
}