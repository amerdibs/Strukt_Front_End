using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcScribe;


namespace ProcScribeTests
{
    [TestClass]
    public class GlobalTests
    {
        [TestMethod]
        public void getValueFromStruktValueTest(){
            String str = global.getValueFromStruktValue("");
            Assert.AreEqual("",str);
        }
    }
}
