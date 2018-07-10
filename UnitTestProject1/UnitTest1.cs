using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Test2
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void TestMethod1()
        {
            ConsoleApp2.Program app = new ConsoleApp2.Program();
            String message = app.returnString();
            Assert.AreEqual("Hello World", message);
        }

        //made to fail
        [TestMethod()]
        public void TestMethod2()
        {
            ConsoleApp2.Program app = new ConsoleApp2.Program();
            String message = app.returnString();
            Assert.AreEqual("he lordw", message);
        }

        [TestCategory("Nightly"), TestMethod()]
        public void TestMethod3()
        {
            ConsoleApp2.Program app = new ConsoleApp2.Program();
            String message = app.returnString();
            Assert.AreEqual("Hello World", message);
        }
    }
}
