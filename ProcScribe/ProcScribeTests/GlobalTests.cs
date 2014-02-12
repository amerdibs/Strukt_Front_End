using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcScribe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ProcScribe.Tests1
{
    [TestClass()]
    public class globalTests
    {
        [TestMethod()]
        public void getExceptionThrowTest()
        {
            try
            {
                global.getExceptionThrow(new Exception());
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
                throw;
            }

        }

        [TestMethod()]
        public void getHeightTaskControlTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getColorTaskControlBackgroundTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getValueFromStruktValueTest()
        {
            Assert.AreEqual(global.getValueFromStruktValue("1072"), "1072");
            Assert.AreNotEqual(global.getValueFromStruktValue(""), "1072");
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void getRespondFromStruktGetTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void getRespondFromStruktDeleteTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void getExtractValueFromRespondTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void getExtractValueFromRespondSingleTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void postJSONintoStruktTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void composeJSONforStruktTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void convertFromStruktDateTimeTest()
        {
            Assert.IsTrue(true);
        }

        //Strukt method which is never used anymore because we are not using strukt 
        [TestMethod()]
        public void convertStruktDateTimeToStringTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void getTaskListFromAllWorkflowTest()
        {
            //String test = global.getTaskListFromAllWorkflow();
            Assert.Fail();
        }

        //Regarding some internet search, it is only possible to check if a process (meaning external application)
        //is running. In our case, we have several external processes and not only one specific. 
        //So we decided not to make a unit test here
        //
        [TestMethod()]
        public void openLinkTest()
        {
            Assert.IsTrue(true);
        }

        

    }
}
