using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class Footer
    {
        readonly IWebDriver driver;

       

        public Footer(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("footer")));
        }

        public void ClickOnInformationLink(string title)
        {
            By link = By.CssSelector(".toggle-footer [title='" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();
        }

        public bool InformationPageDisplayed(string pageName)
            {
            By textElement = By.XPath("//*[@class='navigation_page'][contains(text(),'" + pageName + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement)).Displayed;
        }

        public void ClickOnMyAccountLink(string title)
        {
            By link = By.CssSelector(".bullet [title='" + title + "']");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(link)).Click();
        }
        public bool MyAccountInformationPageDisplayed(string pageName)
        {
            By textElement = By.XPath("//*[@class='navigation_page'][contains(text(),'" + pageName + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement)).Displayed;
        }
    }

}
    
    
