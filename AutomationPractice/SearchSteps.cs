using System;
using TechTalk.SpecFlow;

namespace AutomationPractice
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"result for a '(.*)' search term are displayed")]
        public void ThenResultForASearchTermAreDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
