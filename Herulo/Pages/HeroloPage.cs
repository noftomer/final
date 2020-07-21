using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Herulo.Pages
{
    public class HeroloPage
    {
        private IWebDriver driver;

        public HeroloPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ValidateMoveToHeroloPage()
        {
            try
            {
                Common.ValidateMoveToPage("herolo", driver);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}