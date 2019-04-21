using AutomationPractice.Helpers;
using AutomationPractice.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        public object HomePage { get; private set; }

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.signIn);
        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.password, TestConstants.Passwoard);

        }

        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthenticationPage btn = new AuthenticationPage(Driver);
            ut.ClickOnElement(btn.signInBtn);
        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccount ma = new MyAccount(Driver);
            Assert.True(ut.ElementDisplayed(ma.logout), "User is not logged in");

        }

        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            MyAccount ma = new MyAccount(Driver);
            ut.ClickOnElement(ma.wishlist);
        }

        [Then(@"user can add new wishlist")]
        public void ThenUserCanAddNewWishlist()
        {
            MyWishlist mwl = new MyWishlist(Driver);
            Assert.True(ut.ElementDisplayed(mwl.newwsh), "User can not add new wishlist");
        }


        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string email = ut.GenerateRandomEmail();
            ut.EnterTextInElement(ap.cemail, email);
            ut.ClickOnElement(ap.subemail);
        }


        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            CreateAccountPage cap = new CreateAccountPage(Driver);
            ut.EnterTextInElement(cap.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(cap.lastName, TestConstants.LastName);
            string fullname = TestConstants.FirstName + " " + TestConstants.LastName;
            ScenarioContext.Current.Add(TestConstants.FullName, fullname);
            ut.EnterTextInElement(cap.password, TestConstants.Password1);
            ut.EnterTextInElement(cap.firstN, TestConstants.FirstN);
            ut.EnterTextInElement(cap.lastN, TestConstants.LastN);
            ut.EnterTextInElement(cap.address, TestConstants.Address);
            ut.EnterTextInElement(cap.city, TestConstants.City);
            ut.DropdownSelect(cap.state, TestConstants.State);
            ut.EnterTextInElement(cap.zipCode, TestConstants.ZipCode);
            ut.EnterTextInElement(cap.mPhone, TestConstants.MobilePhone);
            ut.EnterTextInElement(cap.alias, TestConstants.Alias);

        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            CreateAccountPage cap = new CreateAccountPage(Driver);
            ut.ClickOnElement(cap.regBtn);
        }


        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            string fullName = ScenarioContext.Current.Get<string>(TestConstants.FullName);
            Assert.True(ut.TextPresentInElement(fullName).Displayed, "User's full name is not displayed");
        }

        [Given(@"user enters a DRESS search term")]
        public void GivenUserEntersADRESSSearchTerm()
        {
            Homepage hp = new Homepage(Driver);
            ut.EnterTextInElement(hp.searchFld, TestConstants.Item);
        }

            
        [Given(@"user submits the search")]
        public void GivenUserSubmitsTheSearch()
        {
            Homepage hp = new Homepage(Driver);
            ut.ClickOnElement(hp.searchBtn);
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            SearchPage sp = new SearchPage(Driver);
            ut.ClickOnElement(sp.firstDress);
            ut.ClickOnElement(sp.firstDress);
        }

        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            PDPPage pdpp= new PDPPage(Driver);
            ut.ClickOnElement(pdpp.addCBtn);
        }

        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            PDPPage pdpp = new PDPPage(Driver);
            ut.ClickOnElement(pdpp.proCheck);
        }
        [Then(@"cart page is opened")]
        public void ThenCartPageIsOpened()
        {
            PDPPage pdpp = new PDPPage(Driver);
            Assert.True(ut.ElementDisplayed(pdpp.cColumn));
            //za then treba nova classa jer prelazimo na novi Page
        }

    }
}
    





