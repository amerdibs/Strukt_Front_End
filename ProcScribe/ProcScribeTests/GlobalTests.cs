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
        }

        [TestMethod()]
        public void getRespondFromStruktGetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getRespondFromStruktDeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getExtractValueFromRespondTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getExtractValueFromRespondSingleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void postJSONintoStruktTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void composeJSONforStruktTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void convertFromStruktDateTimeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void convertStruktDateTimeToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getTaskListFromAllWorkflowTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void openLinkTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void uploadMyFileTest()
        {
            Assert.Fail();
        }

    }
}
