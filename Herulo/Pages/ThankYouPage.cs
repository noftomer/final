using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Herulo.Pages
{
    internal class ThankYouPage
    {
        private IWebDriver driver;

        public ThankYouPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ValidateThankYouMessage()
        {
            try
            {
                Common.ValidateIfElementIsDisplay(ThankYouMessageLocator(), driver);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        private By ThankYouMessageLocator()
        {
            return By.CssSelector("#gatsby-focus-wrapper > div > main > div.thankYou__content-bl9e43-2.kpZLpw > div.thankYou__rightSide-bl9e43-4.dleGxB > h1");
        }
    }
}