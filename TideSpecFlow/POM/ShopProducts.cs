using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class ShopProducts
    {
        public void OpenUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();            
        }
        public void Hover()
        {
            Thread.Sleep(2000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            IWebElement element = BasicClass.driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
            Actions act = new Actions(BasicClass.driver);
            act.MoveToElement(element);
            act.Perform();            
        }
        public void ClickOption()
        {
            Thread.Sleep(3000);
            BasicClass.driver.FindElement(By.XPath("//span[text()='Stain Removal'][1]")).Click();
        }
        public void ClickOnProduct()
        {
            Thread.Sleep(3000);
            BasicClass.driver.FindElement(By.XPath("//div[@ps-sku='030772032213'][1]")).Click();
        }
        public void Retailers()
        {
            Thread.Sleep(4000);
            BasicClass.driver.FindElement(By.XPath("//span[@class='ps-map-geolocation-button']")).Click();
            Thread.Sleep(3000);
            BasicClass.driver.FindElement(By.XPath("//span[text()='63 ct']")).Click();
            string value = BasicClass.driver.FindElement(By.XPath("//span[text()='FIND ONLINE']")).Text;
            string expected = "FIND ONLINE";
            if (value == expected)
            {
                Console.WriteLine("Text is Present");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\ShopProducts.png");
        }
    }
}
