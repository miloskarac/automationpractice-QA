using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using AutomationPractice.Helpers;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps:Base
    {
        Footer ft = new Footer(Driver);

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string option)
        {

            ft.ClickOnInformationLink(option);
            //ime parametra ne ide pod "" a vrednost ide pod ""

        }
        
        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string pageName)
        {
            Assert.True(ft.InformationPageDisplayed(pageName), "Information page is not displayed");
        }
    }
}
