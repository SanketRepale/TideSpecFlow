using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;
using System.Threading;
using OpenQA.Selenium;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.StepFile
{ 
    [Binding]
    public class PositiveSignUp
    {
        ValidSignUp vsu = new ValidSignUp();
        [Given(@"website link")]
        public void GivenWebsiteLink()
        {
            vsu.OpenURL();
        }
        
        [When(@"user click on register button")]
        public void WhenUserClickOnRegisterButton()
        {
            vsu.RegisterButton();
        }
        
        [When(@"user click on SIGN UP button")]
        public void WhenUserClickOnSIGNUPButton()
        {
            vsu.SignUPButton();
        }
        
        [When(@"user enters the valid Username ,Email ID,Password")]
        public void WhenUserEntersTheValidUsernameEmailIDPassword()
        {
            vsu.EnterValidDeta();
        }
        
        [When(@"Click on SignUp")]
        public void WhenClickOnSignUp()
        {
            vsu.CreateAccount();
        }
        
        [Then(@"it should create accoun for user")]
        public void ThenItShouldCreateAccounForUser()
        {
            vsu.AccountCreated();
        }
    }
}
