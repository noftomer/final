using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herulo.Pages
{
    public class WhatsAppPage
    {
        private IWebDriver driver;
        private string handler;
        public WhatsAppPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       
        public void ValidateMoveToWhatsappPage()
        {
            try
            {
                Common.ValidateMoveToPage("https://api.whatsapp.com/", driver);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
