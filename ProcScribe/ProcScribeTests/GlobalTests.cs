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
        public void getColorTaskControlBackgroundTest()
        {
            System.Drawing.Color cColor;
            cColor= System.Drawing.Color.WhiteSmoke;
            System.Drawing.Color rColor = global.getColorTaskControlBackground(cColor, 0);
            //System.Drawing.Color rColor = global.getColorTaskControlBackground(cColor, -1);
            //System.Drawing.Color rColor = global.getColorTaskControlBackground(cColor, +1);
            if (rColor != null)
                Assert.IsTrue(true);
            else
                Assert.Fail();
        }

        [TestMethod()]
        public void getValueFromStruktValueTest()
        {
            Assert.AreEqual(global.getValueFromStruktValue("1072"), "1072");
            //Assert.AreNotEqual(global.getValueFromStruktValue(""), "1072");
        }

        [TestMethod()]
        public void getRespondFromStruktGetTest()
        {
            Assert.AreEqual(global.getRespondFromStruktGet("1072",""), "");
        }

        [TestMethod()]
        public void getRespondFromStruktDeleteTest()
        {
            Assert.AreEqual(global.getRespondFromStruktDelete(Strukt.URL_Workflow, "1072"), "{\"type\":\"success\"}");
            //Assert.AreEqual(global.getRespondFromStruktDelete(Strukt.URL_Workflow, ""), "");

        }
 
        [TestMethod()]
        public void getExtractValueFromRespondTest()
        {
            //Assert.AreEqual(global.getExtractValueFromRespond("{\"values\":[null]}"), "");
            //Assert.AreEqual(global.getExtractValueFromRespond(""), "");
            Assert.AreEqual(global.getExtractValueFromRespond("{\"values\":[{\"workflow\":{\"id\":\"http://strukt.west.uni-koblenz.de/workflow/1745797700\",\"parent_task_id\":\"http://strukt.west.uni-koblenz.de/task/null8122\",\"user_id\":\"http://strukt.west.uni-koblenz.de/user/47\",\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}}]}"), "[{\"id\":\"http://strukt.west.uni-koblenz.de/workflow/1745797700\",\"parent_task_id\":\"http://strukt.west.uni-koblenz.de/task/null8122\",\"user_id\":\"http://strukt.west.uni-koblenz.de/user/47\",\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}]");
        }

        [TestMethod()]
        public void getExtractValueFromRespondSingleTest()
        {
            //Assert.AreEqual(global.getExtractValueFromRespondSingle("{\"values\":[null]}"), "");
            //Assert.AreEqual(global.getExtractValueFromRespondSingle(""), "");
            Assert.AreEqual(global.getExtractValueFromRespondSingle("{\"values\":[{\"workflow\":{\"id\":\"http://strukt.west.uni-koblenz.de/workflow/1745797700\",\"parent_task_id\":\"http://strukt.west.uni-koblenz.de/task/null8122\",\"user_id\":\"http://strukt.west.uni-koblenz.de/user/47\",\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}}]}"), "[{\"id\":\"http://strukt.west.uni-koblenz.de/workflow/1745797700\",\"parent_task_id\":\"http://strukt.west.uni-koblenz.de/task/null8122\",\"user_id\":\"http://strukt.west.uni-koblenz.de/user/47\",\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}]");
  
        }

        [TestMethod()]
        public void postJSONintoStruktTest()
        {
            Assert.IsNotNull(global.postJSONintoStrukt(Strukt.URL_Workflow, "{\"values\": [{\"workflow\": {\"type\":“http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow”}}]}"));
            //Assert.AreNotEqual(global.postJSONintoStrukt(Strukt.URL_Workflow, "{\"values\": [{\"workflow\": {\"type\":“http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow”}}]}"), "{\"values\":[null]}");
            //Assert.AreNotEqual(global.postJSONintoStrukt(Strukt.URL_Workflow, "{\"values\": [{\"workflow\": {\"type\":“http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow”}}]}"), "{\"type\":\"error\"}");
        }

        [TestMethod()]
        public void composeJSONforStruktTest()
        {
            Assert.AreEqual(global.composeJSONforStrukt(Strukt.Type_Workflow,"[{\"id\":\"http://strukt.west.uni-koblenz.de/workflow/1745797700\",\"parent_task_id\":\"http://strukt.west.uni-koblenz.de/task/null8122\",\"user_id\":\"http://strukt.west.uni-koblenz.de/user/47\",\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}]"),"{\"values\":[{\"workflow\":{\"id\":\"http://strukt.west.uni-koblenz.de/workflow/1745797700\",\"parent_task_id\":\"http://strukt.west.uni-koblenz.de/task/null8122\",\"user_id\":\"http://strukt.west.uni-koblenz.de/user/47\",\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}}]}");
        }

        [TestMethod()]
        public void convertFromStruktDateTimeTest()
        {
            DateTime dt = global.convertFromStruktDateTime("02-25-1998");
            Assert.IsNotNull(dt);
        }

        [TestMethod()]
        public void convertStruktDateTimeToStringTest()
        {
            DateTime dt = DateTime.Now;
            Assert.AreEqual(global.convertStruktDateTimeToString(dt), Convert.ToString(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year));
        }
       

    }
}
