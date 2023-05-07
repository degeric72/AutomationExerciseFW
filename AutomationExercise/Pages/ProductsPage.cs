using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise.Pages
{
    class ProductsPage
    {

        readonly IWebDriver _driver;
        public By productsPage = By.ClassName("features_items");
        public By search = By.Name("search");
        public By searchbtn = By.ClassName("fa-search");

        public ProductsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productsPage));
        }

    }
}
