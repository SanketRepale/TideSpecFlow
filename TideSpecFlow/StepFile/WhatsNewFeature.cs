using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class TideWebApplicationSteps
    {
        WhatsNew Wn = new WhatsNew();
        [Given(@"Goto webpage")]
        public void GivenGotoWebpage()
        {
            Wn.GotoUrl();        
        }
        
        [When(@"click on whats new option")]
        public void WhenClickOnWhatsNewOption()
        {
            Wn.ClickONOption();
        }
        
        [When(@"click on read more of any option present there")]
        public void WhenClickOnReadMoreOfAnyOptionPresentThere()
        {
            Wn.ClickReadmore();
        }
        
        [Then(@"it should Display the Information Regarding the selected option")]
        public void ThenItShouldDisplayTheInformationRegardingTheSelectedOption()
        {
            Wn.CheckInfo();
        }
    }
}
