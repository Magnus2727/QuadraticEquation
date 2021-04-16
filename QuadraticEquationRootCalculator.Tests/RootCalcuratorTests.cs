using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquationRootCalculator.Tests
{
    //Mikołaj Koczur
    //INF_ZI/IV Semestr
    //Nr albumu :39254
    [TestFixture]
    public class RootCalcuratorTests
    {
        [Test]
        [TestCase(1, 1, -1)]
        [TestCase(1, 0, -1)]
        [TestCase(1, -1, -1)]
        public void CalculateQuadraticEquationRoots_PositiveFirstNegativeThirdValue_DeltaAlwaysHigherThanZero(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.Greater(rc.Delta, 0);
        }

        [Test]
        [TestCase(1, 1, -1)]
        [TestCase(1, 0, -1)]
        [TestCase(1, -1, -1)]
        public void CalculateQuadraticEquationRoots_DeltaHigherThanZero_TwoRootsExpected(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.AreEqual(rc.Roots.Count, 2);
        }

        [Test]
        [TestCase(-1, 1, 1)]
        [TestCase(-1, 0, 1)]
        [TestCase(-1, -1, 1)]
        public void CalculateQuadraticEquationRoots_NegativeFirstPositiveThirdValue_DeltaAlwaysHigherThanZero(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.Greater(rc.Delta, 0);
        }

        [Test]
        [TestCase(-1, 1, 1)]
        [TestCase(-1, 0, 1)]
        [TestCase(-1, -1, 1)]
        public void CalculateQuadraticEquationRoots_NegativeFirstPositiveThirdValue_TwoRootsExpected(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.AreEqual(rc.Roots.Count, 2);
        }

        [Test]
        [TestCase(1, -2, 1)]
        public void CalculateQuadraticEquationRoots_DeltaEqualsZero_OneRoot(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.AreEqual(rc.Roots.Count, 1);
        }

        [Test]
        [TestCase(1, -2, 1)]
        public void CalculateQuadraticEquationRoots_ExampleWithDeltaEqualsZero_DelatEqualsZero(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.AreEqual(rc.Delta, 0);
        }

        [Test]
        [TestCase(1, -1, 1, "Equation has 0 roots in real domain")]
        [TestCase(1, -1, 1, "Equation has 0 roots in real domain")]
        [TestCase(1, 0, 1, "Equation has 0 roots in real domain")]
        [TestCase(-1, 0, -1, "Equation has 0 roots in real domain")]
        [TestCase(1, 1, 1, "Equation has 0 roots in real domain")]
        [TestCase(-1, 1, -1, "Equation has 0 roots in real domain")]
        [TestCase(-1, -1, -1, "Equation has 0 roots in real domain")]
        public void CalculateQuadraticEquationRoots_ExampleWithDeltaLowerThanZero_ExpectedMessageForZeroRoots(double firstValue, double secondValue, double thirdValue, string message)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.AreEqual(rc.ToString(), message);
        }

        [Test]
        [TestCase(1, -1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(-1, 0, -1)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, -1)]
        [TestCase(-1, -1, -1)]
        public void CalculateQuadraticEquationRoots_ExampleWithDeltaLowerThanZero_ExpectedDeltaLowerthanZero (double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.Less(rc.Delta, 0);
        }

        [Test]
        [TestCase(1, -1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(-1, 0, -1)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, -1)]
        [TestCase(-1, -1, -1)]
        public void CalculateQuadraticEquationRoots_ExampleWithDeltaLowerThanZero_ExpectedZeroRoots(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            Assert.AreEqual(rc.Roots.Count, 0);
        }

        [Test]
        [TestCase(0, -1, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(0, -1, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, -1, -1)]
        [TestCase(0, 0, -1)]
        [TestCase(0, 1, -1)]
        public void CalculateQuadraticEquationRoots_ExampleWithFirstValueZero_ExpectedException(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            Assert.Throws<Exception>(() => rc.RootCalculate());
        }
        [Test]
        [TestCase(1, -2, 1)]
        public void CalculateQuadraticEquationRoots_RootCalculateMethodNotUsed_ExpectedNanDelta(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            Assert.AreEqual(rc.Delta, Double.NaN);
        }
        [Test]
        [TestCase(1, -2, 1)]
        public void CalculateQuadraticEquationRoots_RootCalculateMethodNotUsed_ExpectedRootCountZero(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            Assert.AreEqual(rc.Roots.Count,0);
        }
        [Test]
        [TestCase(1, -2, 1, "Roots were not calculated yet")]
        public void CalculateQuadraticEquationRoots_RootCalculateMethodNotUsed_ExpectedMessage(double firstValue, double secondValue, double thirdValue, string message)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            Assert.AreEqual(rc.ToString(), message);
        }
    }
}
