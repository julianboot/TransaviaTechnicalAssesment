using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransaviaTechnicalAssesment.PageObjects;

namespace TransaviaTechnicalAssesment.Tests
{
    public class DepartStationInputActions
    {
        public static void CloseCookieBanner(IWebDriver driver)
        {
            SeleniumMethods.ClickElement(driver, PageObjectsClass.CloseCookieButton);
        }

        public static void WaitForPageIsLoaded(IWebDriver driver)
        {
            SeleniumMethods.WaitForElementPresent(driver, PageObjectsClass.Topbar);
        }

        public static void InputDepartStation(IWebDriver driver, string stationText)
        {
            SeleniumMethods.SendText(driver, PageObjectsClass.DepartStationInputField, stationText);
        }

        public static void SelectAutosuggestDepartStation(IWebDriver driver, string station)
        {
            IWebElement StaionSelect = driver.FindElement(By.XPath("//*[@class='autocomplete-results']//li[contains(text(), '"+station+"')]"));
            StaionSelect.Click();
        }

        public static void CheckIfDepartStationIsSelected(IWebDriver driver, string departStationSelected)
        {
            string selectedDepartStation = driver.FindElement(PageObjectsClass.DepartStationInputField).Text;

            if(selectedDepartStation==departStationSelected)
            {
                Console.WriteLine(departStationSelected+" is selected");
            }
            else
            {
                Assert.Fail();
                Console.WriteLine(selectedDepartStation + " is not selected");
            }
        }
    }
}
