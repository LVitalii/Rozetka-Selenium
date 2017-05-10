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
        private static IWebDriver driver;
        static string baseUrl = @"http://rozetka.com.ua";

        static AppManager ()
        {
            driver = new ChromeDriver();
            driver.Url = baseUrl;
        }
        
        public IWebDriver Driver
        {
            get { return driver; }
        }



        public void Quit()
        {
            driver.Quit();
        }
    }
}
