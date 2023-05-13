using AutomationExercise.Helpers;
using AutomationExercise.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding]
    public class ProductsSteps : Base

    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        private readonly ProductData productData;

        public ProductsSteps(ProductData productData)
        {
            this.productData = productData;
        }

    
        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ut.ClickOnElement(hp.productsLink);
        }
        
        [When(@"user enters search product")]
        public void WhenUserEntersSearchProduct()
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.EnterTextInElement(pp.search, TestConstants.SearchProduct);
        }
        
        [When(@"user clicks on the search field")]
        public void WhenUserClicksOnTheSearchField()
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.ClickOnElement(pp.searchbtn);
        }
        
        [Then(@"user will see the title message '(.*)' on the search product page")]
        public void ThenUserWillSeeTheTitleMessageOnTheSearchProductPage(string message)
        {
            Assert.True(ut.TextPresentInElement(message), "Searched Products are not displayed");
        }

        [When(@"opens first search result")]
        public void WhenOpensFirstSearchResult()
        {
            ProductsPage pdp = new ProductsPage(Driver);
            ut.ClickOnElement(pdp.viewProduct);
        }

        [When(@"user clicks on Add to Cart buton")]
        public void WhenUserClicksOnAddToCartButon()
        {
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            productData.ProductName = ut.ReturnTextFromElement(pdp.productName);
            ut.ClickOnElement(pdp.addBtn);

        }

        [When(@"proceeds to the cart")]
        public void WhenProceedsToTheCart()
        {
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            ut.ClickOnElement(pdp.viewCart);
        }

        [Then(@"shopping cart will be displayed expected product inside")]
        public void ThenShoppingCartWillBeDisplayedExpectedProductInside()
        {
            Assert.True(ut.TextPresentInElement(productData.ProductName), "Expected product is not in the cart");
        }


    }
}
