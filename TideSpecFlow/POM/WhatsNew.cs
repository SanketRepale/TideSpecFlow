using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class WhatsNew
    {
        public void GotoUrl()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
        }
        public void ClickONOption()
        {
            Thread.Sleep(2000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//a[@data-action-detail='What’s New']")).Click();
        }
        public void ClickReadmore()
        {
            BasicClass.driver.FindElement(By.XPath("//a[@href='/en-us/shop/type/laundry-pods/tide-hygienic-clean-heavy-duty-10x-power-pods-free'][2]")).Click();
        }
        public void CheckInfo()
        {
            string value = BasicClass.driver.FindElement(By.XPath("//h1[text()=' Heavy Duty 10X ']")).Text;
            string expected = "Heavy Duty 10X";
            if (value == expected)
            {
                Console.WriteLine("Information Related to the selected read more option is displayed sucessfully");
            }
            else
            {
                Console.WriteLine("Information Related to the selected read more option is not displayed sucessfully");
            }
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\WhatsNew.png");
        }
    }
}
