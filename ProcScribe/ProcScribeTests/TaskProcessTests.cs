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
    public class TaskProcessTests
    {
        [TestMethod()]
        public void getTaskProcessAllTest()
        {
            int temp = TaskProcess.getTaskProcessAll().Count;
            Assert.AreNotEqual(temp, 0);
        }
    }
}
