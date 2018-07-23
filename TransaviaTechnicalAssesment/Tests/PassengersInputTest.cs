using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TransaviaTechnicalAssesment.Tests.PassengersInputActions;

namespace TransaviaTechnicalAssesment.Tests
{
    [TestFixture]
    public class PassengersInputTest : TestBase
    {
        [Test]
          public void AddMaxAmountPassengers()
            {
                Setup();

                SeleniumMethods.LoadUrlWithPath(driver, "https://www.transavia.com/en-NL/home/");

                WaitForPageIsLoaded(driver);
                CloseCookieBanner(driver);
                ClickPassengersInput(driver);
                ClickAddAdults(driver, 25);
                CheckForDiplayedNotification(driver);
            }
        }
}

