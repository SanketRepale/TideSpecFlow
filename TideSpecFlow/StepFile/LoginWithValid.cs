using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class LoginWithValid
    {
        ValidLogin Vl = new ValidLogin();
        [Given(@"open website link")]
        public void GivenOpenWebsiteLink()
        {
            Vl.OpenURL();
        }
        
        [When(@"user should click on register button")]
        public void WhenUserShouldClickOnRegisterButton()
        {
            Vl.RegisterButton();
        }
        
        [When(@"user click on LOGIN button")]
        public void WhenUserClickOnLOGINButton()
        {
            Vl.LoginButton();
        }
        
        [When(@"user enters the Valid Email ID ,Password")]
        public void WhenUserEntersTheValidEmailIDPassword()
        {
            Vl.EnterValidData();
        }
        
        [When(@"Click on Login button")]
        public void WhenClickOnLoginButton()
        {
            Vl.clickOnLogin();
        }
        
        [Then(@"it should Login to user Account")]
        public void ThenItShouldLoginToUserAccount()
        {
            Vl.loggedIn();
        }
    }
}
