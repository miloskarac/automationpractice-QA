using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        public object ContactPage { get; private set; }

        [Given(@"User opens a contact page")]
        public void GivenUserOpensAContactPage()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.cLink);
        }
        [Given(@"User enters all required  details")]
        public void GivenUserEntersAllRequiredDetails()
        {
            ContactPage cp = new ContactPage(Driver);
            ut.DropdownSelect(cp.CService, TestConstants.CService);
            ut.EnterTextInElement(cp.Email, TestConstants.Username);
            ut.EnterTextInElement(cp.Msg, TestConstants.Msg);
        }

        [When(@"User send the message")]
        public void WhenUserSendTheMessage()
        {
            ContactPage cp = new ContactPage(Driver);
            ut.ClickOnElement(cp.SubMsg);
        }

        [Then(@"Message has been sent")]
        public void ThenMessageHasBeenSent()
        {
            ContactPage cp = new ContactPage(Driver);
            Assert.True(ut.ElementDisplayed(cp.MsgSent), "Your message has been successfully sent to our team.");
            //has not
        }

    }
}
