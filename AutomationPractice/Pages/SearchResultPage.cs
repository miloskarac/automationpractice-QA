using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class SearchPage

    {
        readonly IWebDriver driver;

       
        public By firstDress = By.Id("color_22");
        public By searchResult = By.Id("columns");


        public SearchPage(IWebDriver driver)
        { 
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("columns")));
        }

    }
}
