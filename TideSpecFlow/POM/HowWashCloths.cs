using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class HowWashCloths
    {
        public void BrowseUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();  
        }
        public void Hover()
        {
            IWebElement element = BasicClass.driver.FindElement(By.XPath("//a[@data-action-detail='How to Wash Clothes']"));
            Actions act = new Actions(BasicClass.driver);
            act.MoveToElement(element);
            act.Perform();
            Thread.Sleep(3000);
        }
        public void ChooseOption()
        {
            BasicClass.driver.FindElement(By.XPath("//span[text()='How to Remove Stains'][1]")).Click();
        }
        public void Readmore()
        {
            BasicClass.driver.FindElement(By.XPath("//a[text()='Acne Cream']")).Click();
        }
        public void VerifyInfo()
        {
            string value = BasicClass.driver.FindElement(By.XPath("//h1[text()='How to Remove Acne Cream Stains']")).Text;
            string expected = "How to Remove Acne Cream Stains";
            if (value == expected)
            {
                Console.WriteLine("Text is Present");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\HowToWashCloths.png");

        }
    }
}
