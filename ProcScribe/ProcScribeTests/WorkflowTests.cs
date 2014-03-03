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
        public void addWorkflowTest()
        {
            Workflow wf = Workflow.addWorkflow();
            Assert.IsNotNull(wf);
            
        }

        [TestMethod()]
        public void editWorkflowTest()
        {
            List<Workflow> lwf = Workflow.getWorkflowByID("1072");
            lwf[0].type = "test";
            Assert.IsNotNull(Workflow.editWorkflow(lwf[0]));
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
