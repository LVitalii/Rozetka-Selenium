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
            app = AppManager.GetInstance();
        }

        [TestMethod]
        public void Search()
        {
            string searchWord = "Hyundai";
            app.FilteringHelper.SearchByWord(searchWord);
            //Assert.IsTrue(app.FilteringHelper.ResultsContain(searchWord));
            //Assert.IsTrue(app.FilteringHelper.Show32ProductExists());
        }

    }
}
