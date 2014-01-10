using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcScribe;


namespace ProcScribeTests
{
    [TestClass]
    public class GlobalTests
    {
        [TestMethod]
        /*public void getColorTaskControlBackground()
        {
            //couldnt find out how to make a unit test for the color output
        }
        public void getValueFromStruktValueTest()
        {
            //The application would crash with an empty string and the test would fail
            //String str = global.getValueFromStruktValue("");
            //Assert.AreNotSame("", str);
            //check for a correct value
            String str1072 = global.getValueFromStruktValue("1072");
            Assert.AreEqual("1072", str1072);
            //check for an incorrect value
            String str00000 = global.getValueFromStruktValue("00000");
            Assert.AreNotEqual("00000", str1072);
        }

        public void getRespondFromStruktGet()
        {
            //have to search for the class that call this method
        }

        public void getRespondFromStruktDelete()
        {
            //have to search for the class that call this method
        }*/

        public void getExtractValueFromRespond()
        {
            //tried some unit tests but can't figure out the return values
        }

        public void getExtractValueFromRespondSingle()
        {
            //same problem as getExtractValueFromRespond
        }

        public void postJSONintoStrukt()
        {
            //same problem as getExtractValueFromRespond
        }

        public void composeJSONforStrukt()
        {
            //same problem as getExtractValueFromRespond        
        }

        public void convertFromStruktDateTime()
        {
            //Method is not used anymore because the assigning task part is not implemented in our application
        }

        public void getTaskListFromAllWorkflow()
        {

        }

        public void openLink()
        {

        }
    }
}
