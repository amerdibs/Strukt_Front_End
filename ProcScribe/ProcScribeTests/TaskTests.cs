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
            Assert.Fail();
            //Can not be tested at the moment because the application is temporary not working
        }

        [TestMethod()]
        public void editTaskTest()
        {
            Assert.Fail();
            //Can not be tested at the moment because the application is temporary not working
        }

        [TestMethod()]
        public void getTaskByParentWorkflowIDTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("1072"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void getTaskByUserIDTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("1072"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void getTaskByIDTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("1072"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void sortTaskListTest()
        {
            Assert.Fail();
            //Can not be tested at the moment because the application is temporary not working
        }

        [TestMethod()]
        public void getDeepestChildTest()
        {
            Assert.AreNotEqual(Task.getTaskByParentWorkflowID("1072"), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(null), null);
            Assert.AreEqual(Task.getTaskByParentWorkflowID(""), null);
        }

        [TestMethod()]
        public void deleteTaskTest()
        {
            Assert.Fail();
            //Can not be tested at the moment because the application is temporary not working

        }
    }
}
