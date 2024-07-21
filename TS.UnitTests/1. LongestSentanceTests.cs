using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TS.Domain;

namespace TS.UnitTests
{
    [TestClass]
    public class LongestSentanceTests
    {
        [TestMethod]
        public void Q1_BasicNominalTest()
        {
            // Arrange
            LongestSentance longestSentance = new LongestSentance();

            // Act
            var input = $"Forget CVs..Save time . x x";
            var outcome = longestSentance.GetLongestSentance(input);

            // Assert
            Assert.AreEqual(2, outcome);
        }
    }
}
