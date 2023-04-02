using AutomationExercise.Helpers;
using AutomationExercise.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding]
    public class ContacUsSteps : Base
    { 
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);


    
        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            ut.ClickOnElement(hp.contactLink);
        }
        
        [When(@"user enters all required fields")]
        public void WhenUserEntersAllRequiredFields()
        {
            ContacUsPage cup = new ContacUsPage(Driver);
            ut.EnterTextInElement(cup.name, TestConstants.FirstName + " " + TestConstants.LastName);
            ut.EnterTextInElement(cup.email, TestConstants.Username);
            ut.EnterTextInElement(cup.subject, TestConstants.Subject);
            ut.EnterTextInElement(cup.message, TestConstants.Message);
        }
        
        [When(@"submits contac us form")]
        public void WhenSubmitsContactUsForm()
        {
            ContacUsPage cup = new ContacUsPage(Driver);
            ut.ClickOnElement(cup.submit);
        }
        
        [When(@"confirm the prompt message")]
        public void WhenConfirmThePromptMessage()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
        }
        
        [Then(@"user will receive '(.*)' message")]
        public void ThenUserWillReceiveMessage(string successMessage)
        {
            Assert.True(ut.TextPresentInElement(successMessage), "User's message was not successfully sent via contact us form");
        }
    }
}
