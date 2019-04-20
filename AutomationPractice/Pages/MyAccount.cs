using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{

    class MyAccount
    {
        readonly IWebDriver driver;
        public By logout = By.ClassName("logout");
        public By wishlist = By.ClassName("icon-heart");
        
        public MyAccount(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("my-account")));

        }

        
       

    }

}  
    
    

