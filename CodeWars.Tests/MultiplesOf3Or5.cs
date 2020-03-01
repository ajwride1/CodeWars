using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class MultiplesOf3Or5
    {
        [TestMethod]
        public void Solution()
        {
            Assert.AreEqual(23, CodeWars.MultiplesOf3Or5.Solution(10));
        }

        [TestMethod]
        public void AlternateSolution()
        {
            Assert.AreEqual(23, CodeWars.MultiplesOf3Or5.AlternateSolution(10));
        }
    }
}
