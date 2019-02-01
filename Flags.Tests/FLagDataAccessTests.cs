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
        public void GetAFCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(57).CountryCode, "AF");

        [TestMethod]
        public void GetGYCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(44).CountryCode, "GY");

        [TestMethod]
        public void GetHRCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(7).CountryCode, "HR");

        [TestMethod]
        public void GetBDCountryFlag() => Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(53).CountryCode, "BD");



    }
}
