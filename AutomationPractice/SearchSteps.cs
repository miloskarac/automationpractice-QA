using AutomationPractice.Helpers;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationPractice.Pages;
using NUnit.Framework;

namespace AutomationPractice
{
    [Binding]
    public class SearchSteps
    {
        public IWebDriver Driver { get; private set; }

        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string p0)
        {
            Utilities ut = new Utilities(Driver);
            Homepage hp = new Homepage(Driver);
            ut.EnterTextInElement(hp.searchFld, p0);
        }
        
        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            Homepage hp = new Homepage(Driver);
            Utilities ut = new Utilities(Driver);
            ut.ClickOnElement(hp.searchBtn);
        }

        [Then(@"result for a '(.*)' search term are displayed")]
        public void ThenResultForASearchTermAreDisplayed(string p0)
        {
            SearchPage sp = new SearchPage(Driver);
            Utilities ut = new Utilities(Driver);
            Assert.True(ut.ElementDisplayed(sp.searchResult));

        }
    }
}
