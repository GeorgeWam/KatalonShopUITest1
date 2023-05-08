using KatalonShopUITest.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace KatalonShopUITest.Utilities
{
    public static class Helpers
    {
        public static void ExplicitlyWaitForElement(string locator)
        {

            WebDriverWait wait = new WebDriverWait(Context.driver, TimeSpan.FromSeconds(10));

            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));

        }

        public static void PageScrollDown()
        {
            Thread.Sleep(2000);
            var js = (IJavaScriptExecutor)Context.driver;

            js.ExecuteScript("window.scrollTo(document.body.scrollHeight,300)");
        }

        [AfterScenario]
        public static void CloseApplicationUnderTest()
        {
            Context.CloseBrowserWithApplicationUnderTest();
        }

        public static void HandleClickInteruptedException(IWebElement element)
        {
            try
            {
                element.Click();
            }catch (ElementClickInterceptedException ex)
            {
                // Wait for the element to be clickable
                WebDriverWait wait = new WebDriverWait(Context.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));

                // Click the element again
                element.Click();
            }
            
        }
    }
}
