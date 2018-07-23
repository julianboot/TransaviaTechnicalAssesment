using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaviaTechnicalAssesment
{
    [TestFixture]
    public class TestBase
    {
        public IWebDriver driver;
        string browser = "chrome";

        public void Setup()
        {
            switch (browser)
            {

                case "chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                break;

                case "IE11":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                break;

                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                break;
            }
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
