﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class MPInfoPage
    {
        readonly IWebDriver driver;
        public By Lastname = By.Id("lastname");
        public By.Password = By.Id("old_passwd");

        public MPInfoPage (IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("center_column")));
        }
    }
}
