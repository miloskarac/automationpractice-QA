using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{

    class PDPPage

    {
        readonly IWebDriver driver;

        public By addCBtn = By.Id("add_to_cart");
        public By proCheck = By.ClassName("button-container");
        public By cColumn = By.ClassName("center_column");

        public PDPPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("columns")));

        }
    }

       

}
