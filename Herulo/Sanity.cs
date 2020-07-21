using System;
using Herulo.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Herulo
{
    [TestClass]
    public class Sanity:Base
    {
        [TestMethod]
        public void HowCanWeHelpYouErrorMessages()
        {
            mp.ValidateErrorsOnAllFieldsOnHowCanWeHelpYouMenu();
        }
        [TestMethod]
        public void ClickOnWhatsAppOnTheLeftSide()
        {
            mp.MoveToWhatsappFromLeftSide();
            WhatsAppPage wap = new WhatsAppPage(driver);
            wap.ValidateMoveToWhatsappPage();
         }
        [TestMethod]
        public void MoveToLinkedIn() {
            mp.MoveToLinkIn();
            LinkedInPage lip = new LinkedInPage(driver);
            lip.ValidateMoveToLinkedInPage();
        }
        [TestMethod]
        public void MoveToFacebook() {
            mp.MoveToFacebook();
            Pages.FacebooPage fbp = new Pages.FacebooPage(driver);
            fbp.ValidateMoveToFacebooPage();
        }
        [TestMethod]
        public void MoveToWhatsappFromTheBottomOfThePage() {
            mp.MoveToWhatsappOnBottom();
            WhatsAppPage wap = new WhatsAppPage(driver);
            wap.ValidateMoveToWhatsappPage();
        }
        [TestMethod]
        public void ClickOnWorldIcon() {
            mp.MoveToWorldIcon();
            HeroloPage wap = new HeroloPage(driver);
            wap.ValidateMoveToHeroloPage();
        }
        [TestMethod]
        public void FillHowCanIHelpYouMenu()
        {
            mp.FillHowCanIHelpYouMenu("Tomer", "0544390553", "tomnof81@gmail.com");
            ThankYouPage typ=new ThankYouPage(driver);
            typ.ValidateThankYouMessage();
        }
        [TestMethod]
        public void FillContactUsMenu()
        {
            mp.FillContactUsMenu("Tomer","company", "0544390553", "tomnof81@gmail.com");
            ThankYouPage typ = new ThankYouPage(driver);
            typ.ValidateThankYouMessage();
        }

        [TestMethod]
        public void TalkWithUsMenuErrors() {
            mp.ValidateErrorsOnAllFieldsOnTalkWithUsMenu();
        }
        [TestMethod]
        public void onUnloadPopup()
        {
            mp.fillModalWrapper("tomer","tomnof81@gmail.com","0544390553");
            ThankYouPage typ = new ThankYouPage(driver);
            typ.ValidateThankYouMessage();
        }
    }
}
