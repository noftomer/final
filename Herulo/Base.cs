using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herulo.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Internal;

namespace Herulo
{
    public class Base
    {
        protected IWebDriver driver;
        public MainPage mp;
        //details
        [TestInitialize]
        public void StartBrowser()
        {
            try {

                driver = ConnectToWebDriver(BrowserType.CHROME);
                driver.Url = "http://automation.herolo.co.il";
                mp = new MainPage(driver);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        private IWebDriver ConnectToWebDriver(BrowserType driverType)
        {
            IWebDriver driver = null;
            switch (driverType)
            {
                case BrowserType.CHROME:
                    driver = new ChromeDriver();
                    break;
                case BrowserType.FF:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.IE:
                    driver = new InternetExplorerDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ConstansValues.TIMEOUT);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ConstansValues.TIMEOUT);

            return driver;
        }
        [TestCleanup]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
