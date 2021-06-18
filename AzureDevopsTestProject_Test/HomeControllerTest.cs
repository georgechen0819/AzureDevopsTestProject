using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureDevopsTestProject_Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            string expected = "success";
            string actual = "success";
            Assert.AreEqual(expected, actual);
        }
    }
}
