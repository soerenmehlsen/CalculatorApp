using HandTestCalculatorApp;
using NUnit.Framework;

namespace UnitTestCalculator
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddMethod()
        {
            Assert.Pass();

            double x = calculator.Add(10, 8);

            Assert.That(x,Is.EqualTo(18));

        }

        [Test]
        public void TestSubtractMethod()
        {
            Assert.Pass();

            double x = calculator.Add(10, 8);

            Assert.That(x, Is.EqualTo(2));
        }

        [Test]
        public void TestMultiplyMethod()
        {
            Assert.Pass();

            double x = calculator.Multiply(10, 8);

            Assert.That(x, Is.EqualTo(80));
        }

        [Test]
        public void TestPowerMethod()
        {
            Assert.Pass();

            double x = calculator.Power(10, 8);

            Assert.That(x, Is.EqualTo(80));
        }
    }
}