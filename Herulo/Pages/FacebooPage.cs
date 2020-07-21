using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Herulo.Pages
{
    public class FacebooPage
    {
        private IWebDriver driver;

        public FacebooPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ValidateMoveToFacebooPage()
        {
           
                try
                {
                    Common.ValidateMoveToPage("facebook", driver);
                }
                catch (Exception e)
                {
                    Assert.Fail(e.Message);
                }
            
        }
    }
}