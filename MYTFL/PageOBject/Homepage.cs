using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYTFL.PageOBject
{
    public class Homepage
    {

        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        private IWebElement cookies()
        {
            return driver.FindElement(By.CssSelector("button[id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll'] strong"));
        }
        public void Acceptcookies()
        {
            cookies().Click();
        }
        private IWebElement Travelfrom()
        {
            return driver.FindElement(By.XPath("//input[@id='InputFrom']"));
        }
        public void waitforFROMLocation()
        {
            OpenQA.Selenium.Support.UI.WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@id='stop-points-search-suggestion-2']")));
        }
        public void waitforToLocation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[@id='stop-points-search-suggestion-1']")));
        }
        private IWebElement Travelto()
        {
            return driver.FindElement(By.XPath("(//input[@id='InputTo'])[1]"));
        }
        public void EnterFRomTravelinfo(string location_from)
        {
            Travelfrom().SendKeys(location_from);

        }
        public void EnterTOTravelinfo(string location_from)
        {
            Travelto().SendKeys(location_from);

        }
        private IWebElement fromlocation()
        {
            return driver.FindElement(By.XPath("//span[@id='stop-points-search-suggestion-2']"));
        }
        private IWebElement tolocation()
        {
            return driver.FindElement(By.XPath("//span[@id='stop-points-search-suggestion-1']"));
        }
        public void ClickFROmLocations()
        {
            fromlocation().Click();




        }
        public void ClickTOLocations()
        {
            tolocation().Click();




        }
        private IWebElement timechange()
        {
            return driver.FindElement(By.LinkText("change time"));
        }
        public void ClickChangeTime()
        {
            timechange().Click();
        }
        private IWebElement Day_dropdown()
        {
            return driver.FindElement(By.XPath("(//select[@id='Date'])[1]"));
        }
        public void Select_Day()
        {
            SelectElement sd = new SelectElement(Day_dropdown());
            sd.SelectByValue("20240609");
        }
        private IWebElement Time_dropdown()
        {
            return driver.FindElement(By.XPath("(//select[@id='Time'])[1]"));
        }
        public void Select_Time()
        {
            SelectElement sd = new SelectElement(Time_dropdown());
            sd.SelectByValue("0115");
        }
        private IWebElement Planjourney()
        {
            return driver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
        }
        public JouneyPage ClickPlanMyJourney()
        {
            Planjourney().Click();
            return new JouneyPage(driver);
        }
        private IWebElement FromError()
        {
            return driver.FindElement(By.XPath("//span[@data-valmsg-for='InputFrom']"));
        }
        private IWebElement ToError()
        {
            return driver.FindElement(By.XPath("(//span[@id='InputTo-error'])[1]"));
        }
        public void ErrorfromDisplay()
        {
            string errorMessage = FromError().Text;
            StringAssert.Contains("The From field is required.", errorMessage);

        }
        public void ErrorTODisplay()
        {
            string errorMessage = ToError().Text;
            StringAssert.Contains("The To field is required.", errorMessage);

        }
    }
}
