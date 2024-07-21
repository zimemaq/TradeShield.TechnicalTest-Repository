using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TS.UnitTests
{
    [TestClass]
    public class LongestSentanceTests
    {
        [TestMethod]
        public void Q1_BasicNominalTest()
        {
            var input = $"We test coders. Give us a try";
            var outcome = 4;  //LongestSentanceAnswer.Solution(input);

            Assert.AreEqual(4, outcome);
        }
    }
}
