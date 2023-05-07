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
    }
}
