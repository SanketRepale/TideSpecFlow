using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class SearchBar
    {
        public void OpenUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
        }
        public void EnterData()
        {
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//input[@type='search']")).SendKeys("Tide Ultra OXI Powder Laundry Detergent");
        }
        public void ClickOnSearch()
        {
            BasicClass.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(4000);
        }
        public void DisplayInfo()
        {
            BasicClass.driver.FindElement(By.XPath("//span[text()='Find Retailers'][1]")).Click();
            Thread.Sleep(3000);
            string outputText = BasicClass.driver.FindElement(By.XPath("//span[text()='FIND ONLINE']")).Text;
            string expectedText = "FIND ONLINE";
            if (outputText == expectedText)
            {
                Console.WriteLine("Text is Present");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\searchbox.png");
        }
    }
}
