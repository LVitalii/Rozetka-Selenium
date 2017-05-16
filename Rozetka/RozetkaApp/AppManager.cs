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
        private string baseUrl;

        private AppManager()
        {
            driver = new ChromeDriver();
            baseUrl = @"http://rozetka.com.ua";
        }

        public static AppManager GetInstance()
        {
            if (app == null)
            {
                app = new AppManager();
                app.driver.Navigate().GoToUrl(app.baseUrl);
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
    }
}
