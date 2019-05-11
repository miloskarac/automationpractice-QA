using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class ContactPage
    {
        readonly IWebDriver driver;

        public By CService = By.Id("id_contact");
        public By Email = By.Id("email");
        public By Msg = By.Id("message");
        public By SubMsg = By.Id("submitMessage");
        public By MsgSent = By.Id("columns");
        // promeni id

        public ContactPage (IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("columns")));
            //promeni ID 
        }
    }
}
