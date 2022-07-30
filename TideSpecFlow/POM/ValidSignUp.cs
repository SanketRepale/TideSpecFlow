using System;
using System.Collections.Generic;
using System.Text;
using TideSpecFlow.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using ImageMagick;
using OpenQA.Selenium.Support.Extensions;
using WDSE;
using NPOI.XSSF.UserModel;
using System.IO;

namespace TideSpecFlow.POM
{
    public class ValidSignUp
    {
        public void OpenURL()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();
        }
        public void RegisterButton()
        {
            Thread.Sleep(4000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//a[text()='Register']")).Click(); 
        }
        public void SignUPButton()
        {
            int Scroll = BasicClass.driver.FindElement(By.XPath("//a[@href='https://www.facebook.com/Tide?fref=ts']")).Location.Y;
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)BasicClass.driver;
            js.ExecuteScript("window.scrollTo(0," + Scroll + ")", "");
            BasicClass.driver.FindElement(By.XPath("//button[@class='sticker_close']")).Click();
            Thread.Sleep(1000);
            BasicClass.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();
        }
        public void EnterValidDeta()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> switchTabs = BasicClass.driver.WindowHandles;
            int count = switchTabs.Count;
            foreach (string tab in switchTabs)
            {
                BasicClass.driver.SwitchTo().Window(tab);
            }
            string path = @"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TestData.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var validFirstName = workbook.GetSheetAt(0).GetRow(2).GetCell(1).StringCellValue.Trim();
            var validEmail = workbook.GetSheetAt(0).GetRow(3).GetCell(1).StringCellValue.Trim();
            var validPass = workbook.GetSheetAt(0).GetRow(4).GetCell(1).StringCellValue.Trim();
            Thread.Sleep(1000);
            BasicClass.driver.FindElement(By.XPath("//input[@id='name']")).SendKeys(validFirstName);
            Thread.Sleep(1000);
            BasicClass.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(validEmail);
            BasicClass.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(validPass);            
        }
        public void CreateAccount()
        {
            BasicClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
        }
        public void AccountCreated()
        {
            Thread.Sleep(3000);
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\validSignup.png");
        }
    }
}
