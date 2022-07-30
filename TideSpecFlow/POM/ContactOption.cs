using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class ContactOption
    {
        public void OpenUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
        }
        public void ClickOnContactUs()
        {
            Thread.Sleep(2000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//a[text()='Contact Us']")).Click();
        }
        public void DisplayOptions()
        {
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\contactus.png");
        }
    }
}
