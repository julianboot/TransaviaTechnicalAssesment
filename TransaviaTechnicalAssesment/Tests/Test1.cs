using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransaviaTechnicalAssesment.PageObjects;

namespace TransaviaTechnicalAssesment.Tests
{
    [TestFixture]
    public class Test1 : TestBase
    {
        [Test]
        public void Test11()
        {
            Setup();

            PageObjectsClass pageObjects = new PageObjectsClass(driver);
            SeleniumMethods.LoadUrlWithPath(driver, "https://www.transavia.com/en-NL/home/");
            Cookie cookie = new Cookie("cookies_accepted", "false");
            driver.Manage().Cookies.AddCookie(cookie);

            //Thread.Sleep(40000);
            //driver.FindElement(By.Id("routeSelection_DepartureStation-input")).SendKeys("Amsterdam");
        }
    }
}
