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
            SeleniumMethods.WaitForElementDisplayed(driver, PageObjectsClass.CloseCookieButton);
            SeleniumMethods.ClickElement(driver, PageObjectsClass.CloseCookieButton);
        }

        public static void InputDepartStation(IWebDriver driver, string stationText)
        {
            SeleniumMethods.SendText(driver, PageObjectsClass.DepartStationInputField, stationText);
        }

        public static void SelectAutosuggestDepartStation(IWebDriver driver, string station)
        {
            IWebElement StaionSelect = driver.FindElement(By.XPath("//*[@class='autocomplete-results']//li[contains(text(), '"+station+"')]"));
            StaionSelect.Click();
            Console.WriteLine("Depart station is selected");
        }

        public static void CheckIfDepartStationIsSelected(IWebDriver driver, string departStationSelected)
        {
            string TextCheck = driver.FindElement(PageObjectsClass.DepartStationInputField).Text;
            //string TextCheck = driver.FindElement(PageObjectsClass.DepartStationInputField).GetAttribute("value");

            if (TextCheck.Contains(departStationSelected))
            {
                Console.WriteLine("Element contains text: " + departStationSelected);
            }
            else
            {
                Console.WriteLine("Element does not contain text: " + departStationSelected);
                Assert.Fail();
            }
        }
    }
}
