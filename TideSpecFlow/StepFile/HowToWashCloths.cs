using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class HowToWashCloths
    {
        HowWashCloths Hwc = new HowWashCloths();
        [Given(@"goto website link")]
        public void GivenGotoWebsiteLink()
        {
            Hwc.BrowseUrl();
        }
        
        [When(@"hover the mouse on the how to wash cloths feature")]
        public void WhenHoverTheMouseOnTheHowToWashClothsFeature()
        {
            Hwc.Hover();
        }
        
        [When(@"click on how to Remove stains option")]
        public void WhenClickOnHowToRemoveStainsOption()
        {
            Hwc.ChooseOption();
        }
        
        [When(@"click on the read more option present under subfeature")]
        public void WhenClickOnTheReadMoreOptionPresentUnderSubfeature()
        {
            Hwc.Readmore();
        }
        
        [Then(@"it should Display the Information Related to the selected option")]
        public void ThenItShouldDisplayTheInformationRelatedToTheSelectedOption()
        {
            Hwc.VerifyInfo();
        }
    }
}
