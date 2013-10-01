using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Mockup2;



namespace UnitTestProcScribe
{
    [TestClass]
    public class UserTests
    {

        [TestMethod]
        public void TestMethodgetUserNameByStruktID(string strUserID)
        {
            DataRow dtRow = User.getUserNameByStruktID("");
            Assert.AreEqual(null, dtRow);
        }

    }
}
