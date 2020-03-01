using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestClass]
    public class DisemvowelTrolls
    {
        private const string ExpectedOutcome = "Ths wbst s fr lsrs LL!";
        private const string Input = "This website is for losers LOL!";

        [TestMethod]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual(ExpectedOutcome, DisemvowellTrolls.Disemvowel(Input));
        }

        [TestMethod]
        public void Alternate()
        {
            Assert.AreEqual(ExpectedOutcome,DisemvowellTrolls.Alternate(Input));
        }
    }
}
