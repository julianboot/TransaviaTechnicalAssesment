using NUnit.Framework;
using OpenQA.Selenium;
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
        }

        public static void ClickElement(this IWebDriver driver, By by)
        {
            driver.FindElement(by).Click();
            Console.WriteLine("Element with locator " + by + " was clicked.");
        }

        public static void CloseCookieBanner(this IWebDriver driver)
        {
            ClickElement(driver, PageObjectsClass.CloseCookieButton);
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By by)
        {
            try
            {
                if (driver.FindElement(by).Displayed)
                    return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return false;
        }

        public static void SendText(this IWebDriver driver, By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
        }

        public static void WaitForElementPresent(this IWebDriver driver, By by)
        {
            for (int quarterSeconds = 0; ; quarterSeconds++)
            {
                if (quarterSeconds >= 80) Assert.Fail("Time out: element with locator " + by + " not found.");
                try
                {
                    if (IsElementPresent(driver, by))
                        Console.WriteLine("Element with locator " + by + " found.");
                    break;
                }
                catch (Exception)
                {
                }
                Thread.Sleep(250);
            }
        }

        public static bool IsElementPresent(this IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
