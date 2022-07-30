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
    public class InvalidSignUP
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
            Thread.Sleep(1000);
        }
        public void EnterInValidDeta()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> switchTabs = BasicClass.driver.WindowHandles;
            int count = switchTabs.Count;
            foreach (string tab in switchTabs)
            {
                BasicClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(3000);
            string path = @"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TestData.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var inValidFirstName = workbook.GetSheetAt(0).GetRow(7).GetCell(1).StringCellValue.Trim();
            var inValidEmail = workbook.GetSheetAt(0).GetRow(8).GetCell(1).StringCellValue.Trim();
            var inValidPass = workbook.GetSheetAt(0).GetRow(9).GetCell(1).StringCellValue.Trim();
            BasicClass.driver.FindElement(By.XPath("//input[@id='name']")).SendKeys(inValidFirstName);
            string firstName = BasicClass.driver.FindElement(By.XPath("//p[text()='First Name is invalid.']")).Text;
            string expectedFirstName = "First Name is invalid.";
            if (firstName == expectedFirstName)
            {
                Console.WriteLine("First Name is invalid.");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }

            Thread.Sleep(1000);
            BasicClass.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(inValidEmail);
            string email = BasicClass.driver.FindElement(By.XPath("//p[text()='Email Not Valid']")).Text;
            string expectedEmail = "Email Not Valid";
            if (email == expectedEmail)
            {
                Console.WriteLine("Email Not Valid");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
            BasicClass.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(inValidPass);
            string pass = BasicClass.driver.FindElement(By.XPath("//p[text()='Password Must Contain Uppercase Letters']")).Text;
            string expectedPass = "Password Must Contain Uppercase Letters";
            if (pass == expectedPass)
            {
                Console.WriteLine("Password Must Contain Uppercase Letters");
            }
            else
            {
                Console.WriteLine("Text is Not Present");
            }
        }
        public void CreateAccount()
        {
            BasicClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
        }
        public void ErrorMessagesVerified()
        {
            Thread.Sleep(3000);
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\invalidSignup.png");
        }
    }
}
