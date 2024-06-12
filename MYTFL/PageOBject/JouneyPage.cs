
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MYTFL.PageOBject
{
   public class JouneyPage
    {
        private IWebDriver driver;

        public JouneyPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        private IWebElement JourneyError()
        {
            return driver.FindElement(By.XPath("//div[@class='info-message disambiguation']//span[1]"));
        }
        public void Sleep()
        {
            Thread.Sleep(10000);
        }
        public void PickError()
        {
            string errorMessage = JourneyError().Text;
            StringAssert.Contains("We found more than one location matching 'jaguarhfn'", errorMessage);

        }
        private IWebElement PlannedJourneyTransport()
        {
            return driver.FindElement(By.XPath("//h2[normalize-space()='Cycling and other options']"));
        }
        public void GetJourneysBYTransport()
        {
            string JourneyMessage = PlannedJourneyTransport().Text;
            StringAssert.Contains("Cycling and other options", JourneyMessage);
        }
    }
}
