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

            SeleniumMethods.LoadUrlWithPath(driver, "https://www.transavia.com/en-NL/home/");
        }
    }
}
