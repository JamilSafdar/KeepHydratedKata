using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KeepHydratedKata
{
    [TestClass]
    public class KeepHydratedTests
    {
        [TestMethod]
        public void GivenTimeCycling_ReturnLitresDrank()
        {
            //arrange
            var hoursCycled = 2;
            var expectedLitresDrank = 1;

            //act
            var actualLitresDrank = Calculator.ConvertTimeCycledToLitresDrank(hoursCycled);

            //assert
            Assert.AreEqual(expectedLitresDrank, actualLitresDrank);
        }

        [TestMethod]
        public void GivenResult_RoundDownToNearestInteger()
        {
            //arrange
            var hoursCycled = 1.4;
            var expectedLitresDrank = 0;

            //act
            var actualLitresDrank = Calculator.ConvertTimeCycledToLitresDrank(hoursCycled);

            //assert
            Assert.AreEqual(expectedLitresDrank, actualLitresDrank);
        }

        [TestMethod]
        public void GivenASecondResult_RoundDownToNearestInteger()
        {
            //arrange
            var hoursCycled = 12.3;
            var expectedLitresDrank = 6;

            //act
            var actualLitresDrank = Calculator.ConvertTimeCycledToLitresDrank(hoursCycled);

            //assert
            Assert.AreEqual(expectedLitresDrank, actualLitresDrank);
        }
    }
}
