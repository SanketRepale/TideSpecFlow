using System;
using TechTalk.SpecFlow;
using TideSpecFlow.POM;

namespace TideSpecFlow.FeatureFile
{
    [Binding]
    public class ShopProductFunction
    {
        ShopProducts Sp = new ShopProducts();
        [Given(@"visit webapplication")]
        public void GivenVisitWebapplication()
        {
            Sp.OpenUrl();
        }
        
        [When(@"user hover on shop products")]
        public void WhenUserHoverOnShopProducts()
        {
            Sp.Hover();
        }
        
        [When(@"user click on any option present in by type")]
        public void WhenUserClickOnAnyOptionPresentInByType()
        {
            Sp.ClickOption();
        }
        
        [When(@"user should click on any product availaible in the products")]
        public void WhenUserShouldClickOnAnyProductAvailaibleInTheProducts()
        {
            Sp.ClickOnProduct();
        }
        
        [Then(@"click on the retailer button to see nearby retailers")]
        public void ThenClickOnTheRetailerButtonToSeeNearbyRetailers()
        {
            Sp.Retailers();
        }
    }
}
