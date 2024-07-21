using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TS.Domain.Services;

namespace TS.UnitTests
{
    [TestClass]
    public class DeepestPitTests
    {
        [TestMethod]
        public void Q2_BasicNominalTest()
        {
            // Arrange
            DeepestPit deepestPit = new DeepestPit();

            // Act
            int[] inputArray = { 1, 2, 3, 1, 2, 3, 1, 2, 3 };
            var outcome = deepestPit.GetPitDepth(inputArray);

            // Assert
            Assert.AreEqual(2, outcome);
        }
    }
}
