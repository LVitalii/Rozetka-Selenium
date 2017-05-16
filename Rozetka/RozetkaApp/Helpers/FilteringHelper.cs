using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RozetkaApp
{
    public class FilteringHelper : BaseHelper
    {
        public FilteringHelper(AppManager manager) : base(manager)
        { 
        }

        public void SearchByWord(string searchWord)
        {
            IWebElement searchField = driver.FindElement(By.CssSelector("input.rz-header-search-input-text.passive"));
            searchField.SendKeys(searchWord);
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[name='rz-search-button']"));
            searchButton.Click();
            string searchResultId = "search_result_title_text"; 
            manager.Wait(searchResultId);
        }

        public bool ResultsContain(string searchWord)
        {

            throw new NotImplementedException();
        }

        public bool Show32ProductExists()
        {
            throw new NotImplementedException();
        }
    }
}
