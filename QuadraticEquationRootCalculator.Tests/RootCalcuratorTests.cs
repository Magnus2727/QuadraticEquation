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
        public void testTemplate(double firstValue, double secondValue, double thirdValue)
        {
            RootCalculator rc = new RootCalculator(firstValue, secondValue, thirdValue);
            rc.RootCalculate();
            var result = rc.Delta;
            Assert.Greater(result, 0);
        }
    }
}
