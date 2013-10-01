using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mockup2;
using System.Data;

namespace ProScribeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getUserNameByStruktIDTest()
        {
            DataRow dtRow = User.getUserNameByStruktID("");
            Assert.AreEqual(null, dtRow);
        }
    }
}
