using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TransaviaTechnicalAssesment.PageObjects
{
    public class PageObjectsClass
    {
        private IWebDriver driver;

        public PageObjectsClass(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static By CloseCookieButton = By.CssSelector(".button.info-banner-button.button-call-to-action.info-banner-neg-expandible");
        public static By Topbar = By.XPath("//*[@data-initialized='ui/ResponsiveNavigation']");

        public static By PassengersInputButton = By.Id("booking-passengers-input");
        public static By AddAdultButton = By.CssSelector(".selectfield.adults .button.button-secondary.increase");
        public static By MaxAmountNotification = By.CssSelector(".togglepanel-container.togglepanel-passengers.position-bottom.is-visible-intermediate.is-visible .notification.notification-informative");

        public static By DepartStationInputField = By.Id("routeSelection_DepartureStation-input");

    }
}
