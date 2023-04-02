﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Pages
{
    class ContacUsPage
    {
        readonly IWebDriver _driver;
        public By contactPage = By.Id("contac-page");
        public By name = By.Name("name");
        public By email = By.Name("email");
        public By subject = By.Name("subject");
        public By message = By.Id("message");
        public By submit = By.Name("submit");


        public ContacUsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(contactPage));
                
        }
    }
}
