using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RozetkaApp;

namespace RozetkaTests
{
    [TestClass]
    public class Tests
    {
        protected AppManager app;

        [TestInitialize]
        public void SetUp()
        {
            app = new AppManager();
        }


        [TestMethod]
        public void Test1()
        {
            
        }

        [TestCleanup]
        public void Finish()
        {
            app.Quit();
        }
    }
}
