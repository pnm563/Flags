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
        public void GetMaxCountryFlagIndexNo()
        {

            Assert.AreEqual(dataAccess.GetMaxCountryFlagIndexNo(), 199);
        }

        [TestMethod]
        public void GetCountryFlagsByIndexNo()
        {

            Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(17).CountryCode, "GY");
            Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(40).CountryCode, "BD");
            Assert.AreEqual(dataAccess.GetCountryFlagByIndexNo(104).CountryCode, "HR");

        }


    }
}
