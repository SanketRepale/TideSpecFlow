using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class LanguageChange
    {
        public void OpenUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();            
        }
        public void ClickOnOption()
        {
            Thread.Sleep(2000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//button[text()='US - English']")).Click();            
        }
        public void SelectLanguage()
        {
            BasicClass.driver.FindElement(By.XPath("//a[text()='US - Spanish']")).Click();            
        }
        public void CheckChangedLanguage()
        {
            string outputText = BasicClass.driver.FindElement(By.XPath("//span[text()='Parte de la familia de P&G']")).Text;
            string expectedText = "Parte de la familia de P&G";
            if (outputText == expectedText)
            {
                Console.WriteLine("langauge has been changed to US - Spanish");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\changeLanguage.png");
        }
    }
}
