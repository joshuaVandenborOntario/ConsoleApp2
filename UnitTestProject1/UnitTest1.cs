using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp2.Program app = new ConsoleApp2.Program();
            String message = app.returnString();
            Assert.AreEqual("Hello World", message);
        }
    }
}
