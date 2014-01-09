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
            //List<Workflow> lst = Workflow.getWorkflowByID("");
            //List<Workflow> lst = Workflow.getWorkflowByID(null);
            Assert.AreNotEqual(lst,null);
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
            Assert.Fail();
        }
    }
}

namespace ProcScribeTests
{
    class WorkflowTests
    {
    }
}
