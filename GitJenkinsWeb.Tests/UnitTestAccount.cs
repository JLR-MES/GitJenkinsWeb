using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
namespace GitJenkinsWeb.Tests
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void AddNumTest()
        {
            Account AC = new Account();
            int expected, actual;
            expected = 30;
            actual = AC.AddNum(10,20);
            Assert.AreEqual(expected, actual);
        }
    }
}
