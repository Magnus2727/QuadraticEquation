using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquationRootCalculator.Tests
{
    [TestFixture]
    public class RootCalcuratorTests
    {
        [Test]
        [TestCase(1,1,-1)]
        [Ignore("copy paste template")]
        public void CalculateQuadraticEquationRoots_(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            var result = rc.Delta;
            Assert.Greater(result, 0);
        }

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

    }
}
