using System;
using System.Web;
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
        public void GetMaxCountryFlagIndexNo() => Assert.AreEqual(dataAccess.GetMaxFlagIndexNo(), 199);

        [TestMethod]
        public void GetAFCountryFlag() => Assert.AreEqual(dataAccess.GetFlagByIndexNo(57).ImageFile, "PW");

        [TestMethod]
        public void GetGYCountryFlag() => Assert.AreEqual(dataAccess.GetFlagByIndexNo(44).ImageFile, "TD");

        [TestMethod]
        public void GetHRCountryFlag() => Assert.AreEqual(dataAccess.GetFlagByIndexNo(7).ImageFile, "KN");

        [TestMethod]
        public void GetBDCountryFlag() => Assert.AreEqual(dataAccess.GetFlagByIndexNo(53).ImageFile, "RU");

        [TestMethod]
        public void MultiThing()
        {
            Assert.AreEqual(dataAccess.GetFlagByIndexNo(53).ImageFile, "RU");
            Assert.AreEqual(dataAccess.GetFlagByIndexNo(51).ImageFile, "RU");
        }

        [TestMethod]
        public void UriBuilderThingy()
        {
            var builder = new UriBuilder("http://example.com");
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["foo"] = "bar<>&-baz";
            query["bar"] = "bazinga";
            builder.Query = query.ToString();
            builder.Path = "/api/Flag";
            string url = builder.ToString();
        }
    }
}
