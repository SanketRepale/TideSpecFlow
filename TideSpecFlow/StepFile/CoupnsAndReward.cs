using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.FeatureFile
{
    [Binding]
    public class TideWebApplicationSteps
    {
        CouponsFeature Cf = new CouponsFeature();
        [Given(@"visit the website link")]
        public void GivenVisitTheWebsiteLink()
        {
            Cf.OpenWebpage();
        }
        
        [When(@"click on coupons and reward option")]
        public void WhenClickOnCouponsAndRewardOption()
        {
            Cf.ClickOption();
        }
        
        [When(@"ClicK on save now")]
        public void WhenClicKOnSaveNow()
        {
            Cf.clickSave();
        }
        
        [When(@"the appllication should ask for login and then enter the login credentials")]
        public void WhenTheAppllicationShouldAskForLoginAndThenEnterTheLoginCredentials()
        {
            Cf.EnterData();
        }
        
        [When(@"click on login then cupon is saved in the profile")]
        public void WhenClickOnLoginThenCuponIsSavedInTheProfile()
        {
            Cf.ClickSignUp();
        }
        
        [Then(@"cupon should be saved in the profile after logging into the web page")]
        public void ThenCuponShouldBeSavedInTheProfileAfterLoggingIntoTheWebPage()
        {
            Cf.CheckUP();
        }
    }
}
