using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransaviaTechnicalAssesment.PageObjects;

namespace TransaviaTechnicalAssesment
{
    public static class SeleniumMethods
    {
        public static void LoadUrlWithPath(this IWebDriver driver, string path)
        {
            driver.Navigate().GoToUrl(path);
            Console.WriteLine("URL loaded: "+ path);
        }

        public static void ClickElement(this IWebDriver driver, By by)
        {
            driver.FindElement(by).Click();
            Console.WriteLine("Element with locator " + by + " was clicked.");
        }

        public static void SendText(this IWebDriver driver, By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
            Console.WriteLine("Text entered: "+ text);
        }

        public static IWebElement WaitForElementDisplayed(this IWebDriver driver, By by)
        {
            int timeoutInSeconds = 10;
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            Console.WriteLine("Element displayed: "+ by);
            return driver.FindElement(by);
        }
    }
}
