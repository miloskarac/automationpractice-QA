using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class CreateAccountPage
    {
        readonly IWebDriver driver;

        public By firstName = By.Id("customer_firstname");
        public By lastName = By.Id("customer_lastname");
        public By password = By.Id("passwd");
        public By firstN = By.Id("firstname");
        public By lastN = By.Id("lastname");
        public By address = By.Id("address1");
        public By city = By.Id("city");
        public By state = By.Id("id_state");
        public By zipCode = By.Id("postcode");
        public By mPhone = By.Id("phone_mobile");
        public By alias = By.Id("alias");
        public By regBtn = By.Id("submitAccount");
        

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("account-creation_form")));
        }
    }
}
