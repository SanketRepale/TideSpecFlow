using NPOI.XSSF.UserModel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using TideSpecFlow.Hooks;

namespace TideSpecFlow.POM
{
    public class InvalidLogin
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
        public void LoginButton()
        {
            int Scroll = BasicClass.driver.FindElement(By.XPath("//a[@href='https://www.facebook.com/Tide?fref=ts']")).Location.Y;
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)BasicClass.driver;
            js.ExecuteScript("window.scrollTo(0," + Scroll + ")", "");
            BasicClass.driver.FindElement(By.XPath("//button[@class='sticker_close']")).Click();
            Thread.Sleep(1000);
            BasicClass.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();
            Thread.Sleep(1000);
        }
        public void EnterInValidData()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> switchTabs = BasicClass.driver.WindowHandles;
            int count = switchTabs.Count;
            foreach (string tab in switchTabs)
            {
                BasicClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(3000);
            BasicClass.driver.FindElement(By.XPath("//button[text()='Log in']")).Click();
            Thread.Sleep(2000);
            string path = @"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TestData.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var validEmail = workbook.GetSheetAt(0).GetRow(3).GetCell(1).StringCellValue.Trim();
            var inValidPass = workbook.GetSheetAt(0).GetRow(9).GetCell(1).StringCellValue.Trim();
            BasicClass.driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys(validEmail);
            BasicClass.driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys(inValidPass);
        }
        public void clickOnLogin()
        {
            BasicClass.driver.FindElement(By.XPath("//input[@value='LOG IN']")).Click();
            Thread.Sleep(3000);
        //    string pass = BasicClass.driver.FindElement(By.XPath("//div[text()='Invalid credentials']")).Text;
        //    string expectedPass = "Invalid credentials";
        //    if (pass == expectedPass)
        //    {
        //        Console.WriteLine("Invalid Credentials");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Text is Not Present");
        //    }
        }
        public void InvalidCredentials()
        {
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\Invalidlogin.png");
        }
    }
}
