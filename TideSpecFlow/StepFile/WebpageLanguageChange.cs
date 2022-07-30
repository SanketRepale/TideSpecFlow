using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class WebpageLanguageChange
    {
        LanguageChange Lc = new LanguageChange();
        [Given(@"visit webpage by url")]
        public void GivenVisitWebpageByUrl()
        {
            Lc.OpenUrl();
        }
        
        [When(@"user click on language change dropdown button")]
        public void WhenUserClickOnLanguageChangeDropdownButton()
        {
            Lc.ClickOnOption();
        }
        
        [When(@"select any language option from availaible options")]
        public void WhenSelectAnyLanguageOptionFromAvailaibleOptions()
        {
            Lc.SelectLanguage();
        }
        
        [Then(@"It should Display the web page into that language")]
        public void ThenItShouldDisplayTheWebPageIntoThatLanguage()
        {
            Lc.CheckChangedLanguage();
        }
    }
}
