using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace RozetkaApp
{
    public class AppManager
    {
        private static AppManager app = null;
        private IWebDriver driver;
        private static string baseUrl;
        private SearchHelper searchHelper;
        private FilteringHelper filteringHelper;

        private AppManager ()
        {
            driver = new ChromeDriver();
            baseUrl = @"http://rozetka.com.ua";
            PageInitialization(this);
        }        

        public static AppManager GetInstance()
        {
            if (app == null)
            {
                app = new AppManager();
                app.driver.Navigate().GoToUrl(baseUrl);  
            }
            return app;
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }

        ~AppManager()
        {
            driver.Quit();
        }

        private void PageInitialization(AppManager manager)
        {
            searchHelper = new SearchHelper(manager);
            filteringHelper = new FilteringHelper(manager);
        }

        public SearchHelper SearchHelper
        {
            get { return this.searchHelper; }
        }

        public FilteringHelper FilteringHelper
        {
            get { return this.filteringHelper; }
        }

        public void Wait(string id)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchedWord = wait.Until<IWebElement>(d => d.FindElement(By.Id(id)));
        }
    }
}
