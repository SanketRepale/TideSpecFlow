using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.StepFile
{
    [Binding]
    public class SearchBox
    {
        SearchBar Sb = new SearchBar();
        [Given(@"open webpage link")]
        public void GivenOpenWebpageLink()
        {
            Sb.OpenUrl();
        }
        
        [When(@"enter any product name in search bar")]
        public void WhenEnterAnyProductNameInSearchBar()
        {
            Sb.EnterData();
        }
        
        [When(@"click search button")]
        public void WhenClickSearchButton()
        {
            Sb.ClickOnSearch();
        }
        
        [Then(@"It should display all the products related to the provided info in search bar")]
        public void ThenItShouldDisplayAllTheProductsRelatedToTheProvidedInfoInSearchBar()
        {
            Sb.DisplayInfo();
        }
    }
}
