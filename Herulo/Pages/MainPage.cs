using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herulo.Pages
{
    public class MainPage
    {
        private IWebDriver driver;
        private By howCanWeHelpYouNameTextBox()
        {
            return By.CssSelector("#footer > form > div > div:nth-child(1) > input");
        }
        private By howCanWeHelpYouEmailTextBox()
        {
            return By.CssSelector("#footer > form > div > div:nth-child(2) > input");
        }
        private By howCanWeHelpYouPhoneTextBox()
        {
            return By.CssSelector("#footer > form > div > div:nth-child(3) > input");
        }

        

        private By howCanWeHelpYouButton()
        {
            return By.CssSelector("#footer > form > button");
        }

       

        private By howCanWeHelpYouPhoneError()
        {
            return By.CssSelector("#footer > form > div > div:nth-child(3) > label > span");
        }

        

        private By howCanWeHelpYouEmailError()
        {
            return By.CssSelector("#footer > form > div > div:nth-child(2) > label > span");
        }
        private By howCanWeHelpYouNameError()
        {
            return By.CssSelector("#footer > form > div > div:nth-child(1) > label > span");
        }

        
        private By watsappOnLeftSide()
        {
            return By.CssSelector("#gatsby-focus-wrapper > div > a.callUsWhatsapp__BtnWhatsapp-sc-1bcgurk-0.cPQmgB");
        }

        

        private By linkInIcon()
        {
            return By.CssSelector("#section-contact > section > div.contactUs__ContactDetails-aeumgd-2.bgaatg > div > div.socialMediaBar__SocialMediaBar-sc-1f95hbj-0.jPKFmq > div > a.socialMediaBar__ImgSocial-sc-1f95hbj-2.jCiLrI");
        }

        

        private By faceBookIcon()
        {
            return By.CssSelector("#section-contact > section > div.contactUs__ContactDetails-aeumgd-2.bgaatg > div > div.socialMediaBar__SocialMediaBar-sc-1f95hbj-0.jPKFmq > div > a.socialMediaBar__ImgSocial-sc-1f95hbj-2.gdrWsw");
        }

        public void fillModalWrapper(string name, string email, string phone)
        {
            try
            {

                Common.ValidateIfElementIsDisplay(PopUpModel(), driver,60.0);

                Common.fillTextBox(PopupTextBoxName(), name, driver);
                Common.fillTextBox(PopupTextBoxEmail(), email, driver);
                Common.fillTextBox(PopupTextBoxPhone(), phone, driver);
                //Common.ClickOnButton(PopupButton(), driver);
                //Validateu move to next page
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            
            

        }

        private By PopUpModel()
        {
            return By.CssSelector("body > div.ReactModalPortal > div > div > div");
        }

        private By PopupButton()
        {
            return By.CssSelector("#modal-form > button");
        }

        private By PopupTextBoxPhone()
        {
            return By.CssSelector("#modal-form > div > div:nth-child(3) > input");
        }

        private By PopupTextBoxEmail()
        {
            return By.CssSelector("#modal-form > div > div:nth-child(2) > input");
        }

        private By PopupTextBoxName()
        {
            return By.CssSelector("#modal-form > div > div:nth-child(1) > input");
        }

        private By worldIcon()
        {
            return By.CssSelector("#section-contact > section > div.contactUs__ContactDetails-aeumgd-2.bgaatg > div > div.socialMediaBar__SocialMediaBar-sc-1f95hbj-0.jPKFmq > div > a.socialMediaBar__ImgSocial-sc-1f95hbj-2.gAmXai");
        }
        private By wahtappIconOnBottom()
        {
            return By.CssSelector("#section-contact > section > div.contactUs__ContactDetails-aeumgd-2.bgaatg > div > div.socialMediaBar__SocialMediaBar-sc-1f95hbj-0.jPKFmq > div > a.socialMediaBar__ImgSocial-sc-1f95hbj-2.iZfnyd");
        }
        private By TalkWithUsButton()
        {
            return By.CssSelector("#section-inputs > div.form__ButtonContainer-sc-1ju2h8q-3.chuOPX > a");
        }

        private By TalkWithUsNameError()
        {
            return By.CssSelector("#section-inputs > div:nth-child(1) > div:nth-child(1) > span > span");
        }
        private By TalkWithUsPhoneError()
        {
            return By.CssSelector("#section-inputs > div:nth-child(1) > div:nth-child(2) > span > span");
        }
        private By TalkWithUsEmailError()
        {
            return By.CssSelector("#section-inputs > div:nth-child(2) > div:nth-child(1) > span > span");
        }
        private By TalkWithUsCompanyError()
        {
            return By.CssSelector("#section-inputs > div:nth-child(2) > div:nth-child(2) > span > span");
        }
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void FillHowCanIHelpYouMenu(string name, string phone, string email)
        {
            try
            {
                Common.fillTextBox(this.howCanWeHelpYouNameTextBox(), name, driver);
                Common.fillTextBox(this.howCanWeHelpYouEmailTextBox(), email, driver);
                Common.fillTextBox(this.howCanWeHelpYouPhoneTextBox(), phone, driver);
                Common.ClickOnButton(this.howCanWeHelpYouButton(), driver);
                
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public void FillContactUsMenu(string name, string company, string phone, string email)
        {
            try
            {
                Common.fillTextBox(this.ContactUsNameTextBox(), name, driver);
                Common.fillTextBox(this.ContactUsEmailTextBox(), email, driver);
                Common.fillTextBox(this.ContactUsPhoneTextBox(), phone, driver);
                Common.fillTextBox(this.ContactUsCompanyTextBox(), phone, driver);
                //Common.ClickOnButton(this.TalkWithUsButton(), driver);
                //Validate you are on the next page
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        private By ContactUsCompanyTextBox()
        {
            return By.Id("company");
        }

        private By ContactUsPhoneTextBox()
        {
            return By.Id("telephone");
        }

        private By ContactUsEmailTextBox()
        {
            return By.Id("email");
        }

        public By ContactUsNameTextBox()
        {
            return By.Id("name");
        }

        //validate error msg
        public void ValidateErrorsOnAllFieldsOnHowCanWeHelpYouMenu()
        {
            try
            {
                Common.ClickOnButton(howCanWeHelpYouButton(), this.driver);
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.howCanWeHelpYouNameError(), driver), "The name error does not exists");
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.howCanWeHelpYouPhoneError(), driver), "The phone error does not exists");
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.howCanWeHelpYouEmailError(), driver), "The email error does not exists");

            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public void ValidateErrorsOnAllFieldsOnTalkWithUsMenu()
        {
            try
            {
                Common.ClickOnButton(this.TalkWithUsButton(), this.driver);
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.TalkWithUsNameError(), driver), "The name error does not exists");
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.TalkWithUsPhoneError(), driver), "The phone error does not exists");
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.TalkWithUsEmailError(), driver), "The email error does not exists");
                Assert.IsTrue(Common.ValidateIfElementIsDisplay(this.TalkWithUsCompanyError(), driver), "The email error does not exists");

            } 
            catch (Exception e) 
            {
                Assert.Fail(e.Message);
            }
        }

        







        //validate moveto watsapp
        public void MoveToWhatsappFromLeftSide()
        {
            try
            {
                Common.ClickOnButton(this.watsappOnLeftSide(), driver);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public void MoveToWhatsappOnBottom()
        {
            try
            {
                Common.ClickOnButton(this.wahtappIconOnBottom(), driver);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public void MoveToLinkIn()
        {
            try
            {
                Common.ClickOnButton(linkInIcon(), driver);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public void MoveToFacebook()
        {
            try
            {
                Common.ClickOnButton(faceBookIcon(), driver);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        internal void MoveToWorldIcon()
        {
            try
            {
                Common.ClickOnButton(worldIcon(), driver);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

    }
}
