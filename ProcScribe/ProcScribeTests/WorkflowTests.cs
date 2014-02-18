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
    public class WorkflowTests
    {
        [TestMethod()]
        public void getWorkflowByIDTest()
        {
            List<Workflow> lst = Workflow.getWorkflowByID("31");
            List<Workflow> lst2 = Workflow.getWorkflowByID("");
            List<Workflow> lst3 = Workflow.getWorkflowByID(null);
            Assert.AreNotEqual(lst,null);
            Assert.AreEqual(lst2, null);
            Assert.AreEqual(lst3, null);
        }

        [TestMethod()]
        public void getWorkflowHierarchybyIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void addWorkflowTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void editWorkflowTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteWorkflowTest()
        {
            Assert.AreNotEqual(Workflow.deleteWorkflow("1072"), null);
            //Assert.AreEqual(Workflow.deleteWorkflow(null), null);
            //Assert.AreEqual(Workflow.deleteWorkflow(""), null);
        }
    }
}

namespace ProcScribeTests
{
    class WorkflowTests
    {
    }
}
