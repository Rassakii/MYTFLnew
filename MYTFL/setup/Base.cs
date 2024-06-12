using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MYTFL.setup
{
    [Binding]
    public class Base
    {
        
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()

        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.tfl.gov.uk";
        }
     
        //public IWebDriver getdriver()
        //{
        //    return driver;
        //}
        [TearDown]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
