using AutomationPractice.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace AutomationPractice.Steps
{
    [Binding]
    public class FooterSteps
    {
        Footer ft = new Footer(Driver);

        public static IWebDriver Driver { get; private set; }

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string option)
        {

            ft.ClickOnInformationLink(option);
            //ime parametra ne ide pod "" a vrednost ide pod ""

        }
        
        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string pageName)
        {
            
        }
    }
}
