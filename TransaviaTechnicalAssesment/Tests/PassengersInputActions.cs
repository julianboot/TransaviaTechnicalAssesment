using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TransaviaTechnicalAssesment.PageObjects;

namespace TransaviaTechnicalAssesment.Tests
{
    public class PassengersInputActions
    {

        public static void ClickPassengersInput(IWebDriver driver)
        {
            SeleniumMethods.ClickElement(driver, PageObjectsClass.PassengersInputButton);
        }

        public static void CloseCookieBanner(IWebDriver driver)
        {
            SeleniumMethods.WaitForElementDisplayed(driver, PageObjectsClass.CloseCookieButton);
            SeleniumMethods.ClickElement(driver, PageObjectsClass.CloseCookieButton);
        }

        public static void ClickAddAdults(IWebDriver driver, int numberOfClick = 1)
        {
            for (int i = 0; i < numberOfClick; i++)
            {
                SeleniumMethods.ClickElement(driver, PageObjectsClass.AddAdultButton);
            }
        }

        public static void CheckForDiplayedNotification(IWebDriver driver)
        {
            SeleniumMethods.WaitForElementDisplayed(driver, PageObjectsClass.MaxAmountNotification);
        }
    }
}
