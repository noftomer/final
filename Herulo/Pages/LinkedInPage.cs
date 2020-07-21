using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herulo.Pages
{
    public class LinkedInPage
    {
        private IWebDriver driver;
        public LinkedInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ValidateMoveToLinkedInPage()
        {
            try
            {
                Common.ValidateMoveToPage("linkedin", driver);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
