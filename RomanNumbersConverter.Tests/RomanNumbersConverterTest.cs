using System;

namespace RomanNumbersConverter.Tests
{
    [TestFixture]
    public class RomanNumbersConverterTest
    {
        [Test]
        public void ShouldUnderstandSymbolI()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("I");
            Assert.That(number, Is.EqualTo(1));
        }

        [Test]
        public void ShouldUnderstandSymbolV()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("V");
            Assert.That(number, Is.EqualTo(5));
        }

        [Test]
        public void ShouldUnderstandSymbolX()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("X");
            Assert.That(number, Is.EqualTo(10));
        }

        [Test]
        public void ShouldUnderstandSymbolL()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("L");
            Assert.That(number, Is.EqualTo(50));
        }

        [Test]
        public void ShouldUnderstandSymbolC()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("C");
            Assert.That(number, Is.EqualTo(100));
        }

        [Test]
        public void ShouldUnderstandSymbolD()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("D");
            Assert.That(number, Is.EqualTo(500));
        }

        [Test]
        public void ShouldUnderstandSymbolM()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("M");
            Assert.That(number, Is.EqualTo(1000));
        }

        [Test]
        public void ShouldUnderstandTwoSymbolsLikeII()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("II");
            Assert.That(number, Is.EqualTo(2));
        }

        [Test]
        public void ShouldUnderstantFourSymbolsByTwos()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("XXII");
            Assert.That(number, Is.EqualTo(22));
        }

        [Test]
        public void ShouldUnderstantSymbolsLikeIX()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("IX");
            Assert.That(number, Is.EqualTo(9));
        }

        [Test]
        public void ShouldUnderstantComplexSymbolsLikeXXIV()
        {
            RomanNumbersConverter converter = new RomanNumbersConverter();
            int number = converter.Convert("XXIV");
            Assert.That(number, Is.EqualTo(24));
        }
    }
}