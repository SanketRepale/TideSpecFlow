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
    public class CouponsFeature
    {
        public void OpenWebpage()
        {
            BasicClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            BasicClass.driver.Manage().Window.Maximize();            
        }
        public void ClickOption()
        {
            Thread.Sleep(2000);
            BasicClass.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BasicClass.driver.FindElement(By.XPath("//a[@data-action-detail='Coupons and Rewards']")).Click();            
        } 
        public void clickSave()
        {
            BasicClass.driver.FindElement(By.XPath("//a[text()='Save Now']")).Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> switchTabs = BasicClass.driver.WindowHandles;
            int count = switchTabs.Count;
            foreach (string tab in switchTabs)
            {
                BasicClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(1000);            
        }
        public void EnterData()
        {
            string path = @"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TestData.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var validFirstName = workbook.GetSheetAt(0).GetRow(2).GetCell(1).StringCellValue.Trim();
            var validEmail = workbook.GetSheetAt(0).GetRow(3).GetCell(1).StringCellValue.Trim();
            var validPass = workbook.GetSheetAt(0).GetRow(4).GetCell(1).StringCellValue.Trim();
            BasicClass.driver.FindElement(By.XPath("//input[@id='name']")).SendKeys(validFirstName);
            Thread.Sleep(1000);
            BasicClass.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(validEmail);
            BasicClass.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(validPass);            
        }
        public void ClickSignUp()
        {
            BasicClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            Thread.Sleep(3000);            
        }
        public void CheckUP()
        {
            ((ITakesScreenshot)BasicClass.driver).GetScreenshot().SaveAsFile
                (@"C:\Users\mindc1may74\Desktop\M1089040 Comprehensive Assesment\Automation Using NUnit And BDD\TideSpecFlow\TideSpecFlow\ScreenShorts\couponsandrewards.png");
        }
    }
}
