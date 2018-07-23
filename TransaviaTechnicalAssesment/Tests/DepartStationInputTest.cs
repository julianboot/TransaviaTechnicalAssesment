using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TransaviaTechnicalAssesment.Tests.DepartStationInputActions;

namespace TransaviaTechnicalAssesment.Tests
{
    [TestFixture]
    public class DepartStationInputTest : TestBase
    {
        [Test]
        public void SelectDepartStation()
        {
            Setup();

            SeleniumMethods.LoadUrlWithPath(driver, "https://www.transavia.com/en-NL/home/");

            WaitForPageIsLoaded(driver);
            CloseCookieBanner(driver);
            InputDepartStation(driver, "Amsterdam");
            SelectAutosuggestDepartStation(driver, "Amsterdam (Schiphol), Netherlands");
            CheckIfDepartStationIsSelected(driver, "Amsterdam (Schiphol), Netherlands");
        }
    }
}
