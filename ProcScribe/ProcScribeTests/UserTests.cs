using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcScribe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcScribe.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void getUserNameByStruktIDTest()
        {
            System.Data.DataRow dw =  User.getUserNameByStruktID("1");
            Assert.IsNotNull(dw);
        }
    }
}
