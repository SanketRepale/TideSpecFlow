using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class SignUPwithInvalid
    {
        InvalidSignUP isu = new InvalidSignUP();
        [Given(@"website link open")]
        public void GivenWebsiteLinkOpen()
        {
            isu.OpenURL();
        }
        [When(@"user have to click on register button")]
        public void WhenUserHaveToClickOnRegisterButton()
        {
            isu.RegisterButton();
        }

        [When(@"user have to click on SIGN UP button")]
        public void WhenUserHaveToClickOnSIGNUPButton()
        {
            isu.SignUPButton();
        }

        [When(@"user enters the Invalid Username ,Email ID,Password")]
        public void WhenUserEntersTheInvalidUsernameEmailIDPassword()
        {
            isu.EnterInValidDeta();
        }
        [When(@"user have to Click on SignUp")]
        public void WhenUserHaveToClickOnSignUp()
        {
            isu.CreateAccount();
        }

        [Then(@"it should not create account for user and should display error message")]
        public void ThenItShouldNotCreateAccountForUserAndShouldDisplayErrorMessage()
        {
            isu.ErrorMessagesVerified();
        }
    }
}
