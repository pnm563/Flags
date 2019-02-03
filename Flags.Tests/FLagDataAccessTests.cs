using System;
using DataAccess;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flags.Tests
{
    [TestClass]
    public class FlagDataAccessTests
    {
        FlagDataAccess dataAccess = new FlagDataAccess();

        [TestMethod]
        public void GetMaxCountryFlagIndexNo() => Assert.AreEqual(dataAccess.GetMaxCountryFlagIndexNo(), 199);

        [TestMethod]
        public void GetAFCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(57).CountryCode, "PW");

        [TestMethod]
        public void GetGYCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(44).CountryCode, "TD");

        [TestMethod]
        public void GetHRCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(7).CountryCode, "KN");

        [TestMethod]
        public void GetBDCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(53).CountryCode, "RU");

        [TestMethod]
        public void MultiThing()
        {
            Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(53).CountryCode, "RU");
            Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(51).CountryCode, "RU");
        }

    }
}
