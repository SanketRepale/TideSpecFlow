using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class LoginWithInvalid
    {
        InvalidLogin Iv = new InvalidLogin();
        [Given(@"open webpage")]
        public void GivenOpenWebpage()
        {
            Iv.OpenURL();
        }
        
        [When(@"click on register button")]
        public void WhenClickOnRegisterButton()
        {
            Iv.RegisterButton();
        }
        
        [When(@"click on LOGIN button")]
        public void WhenClickOnLOGINButton()
        {
            Iv.LoginButton();
        }
        
        [When(@"user enters the Valid Email ID & InvalidPassword")]
        public void WhenUserEntersTheValidEmailIDInvalidPassword()
        {
            Iv.EnterInValidData();
        }
        
        [When(@"user Click on Login button")]
        public void WhenUserClickOnLoginButton()
        {
            Iv.clickOnLogin();
        }
        
        [Then(@"it should not Login to user Account")]
        public void ThenItShouldNotLoginToUserAccount()
        {
            Iv.InvalidCredentials();
        }
    }
}
