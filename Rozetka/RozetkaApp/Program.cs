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
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl(@"http://rozetka.com.ua");

        //    IWebElement searchField = driver.FindElement(By.CssSelector("input.rz-header-search-input-text.passive"));
        //    searchField.SendKeys("Hyundai");
        //    IWebElement searchButton = driver.FindElement(By.CssSelector("button[name='rz-search-button']"));
        //    searchButton.Click();
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    IWebElement searchedWord = wait.Until<IWebElement>(d => d.FindElement(By.Id("search_result_title_text")));
        //    driver.Quit();
        //}
    }
}
