using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Data;

namespace Mockup2
{
    [TestFixture]
    public class UserTests
    {
        [TestCase]
        public void getUserNameByStruktIDTest(string strUserID)
        {
            DataRow dtRow = User.getUserNameByStruktID("");
            Assert.AreEqual(null, dtRow);
        }
    }
}
