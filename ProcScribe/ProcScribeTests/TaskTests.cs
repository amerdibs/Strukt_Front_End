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
    public class TaskTests
    {
        [TestMethod()]
        public void addTaskTest()
        {
            Task ta = new Task();
            ta.name = "TestTask";
            Assert.AreNotEqual(Task.addTask(ta), null);
        }

        [TestMethod()]
        public void editTaskTest()
        {
            List<Task> lta = Task.getTaskByID("6");
            lta[0].name = "TestEdit";
            Assert.AreNotEqual(Task.editTask(lta[0]), null);
        }

        [TestMethod()]
        public void getTaskByParentWorkflowIDTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("6"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void getTaskByUserIDTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("6"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void getTaskByIDTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("6"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void getDeepestChildTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("6"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void deleteTaskTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("6"), null);
        }
    }
}
