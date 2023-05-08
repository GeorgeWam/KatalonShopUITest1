using KatalonShopUITest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalonShopUITest.Hooks
{
    public class Context
    {
        //Initiating the Driver and baseURL
        public static IWebDriver driver;

        public static void LaunchApplicationUnderTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://cms.demo.katalon.com/");
            Thread.Sleep(2000);
        }

        //Closing an Application undertest
        public static void CloseBrowserWithApplicationUnderTest()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
