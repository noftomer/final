using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herulo
{
    public class Common
    {
        private static IWebElement waitForElement(By by,IWebDriver driver)
        {
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(ConstansValues.TIMEOUT));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
        public static void fillTextBox(By locator,string text,IWebDriver driver)
        {
            waitForElement(locator,driver).Clear();
            waitForElement(locator,driver).SendKeys(text);
        }
        public static void ClickOnButton(By locator, IWebDriver driver)
        {
            waitForElement(locator, driver).Click();
        }
        public static bool ValidateIfElementIsDisplay(By by, IWebDriver driver, double timeout)
        {
            bool res = true;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(by));

            }
            catch (Exception e)
            {
                res = false;
            }
            return res;
        }
        public static bool ValidateIfElementIsDisplay(By locator,IWebDriver driver)
        {
            bool res =true;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(ConstansValues.TIMEOUT));
                IWebElement element = wait.Until(ExpectedConditions.ElementExists(locator));
                
            }
            catch(Exception e)
            {
                res = false;
            }
            return res;   
        }
        public static void ScrollToBootomOfPage(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        public static void SwitchToNextWindow(IWebDriver driver)
        {
           
                int lastOpenWindow = driver.WindowHandles.Count - 1;
                driver.SwitchTo().Window(driver.WindowHandles[lastOpenWindow]);

           
            
        }
        
        public static void ValidateMoveToPage(string containedExpectedText,IWebDriver driver)
        {
            
                SwitchToNextWindow(driver);
                string actual=driver.Url;
                 Assert.IsTrue(actual.Contains(containedExpectedText), "The url " + containedExpectedText + " is not part of the actual url " + actual);
            
        }

       
    }
}
