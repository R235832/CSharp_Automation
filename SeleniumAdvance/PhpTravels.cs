using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAdvance
{
    public class PhpTravels
    {
        [Test]
        public void PhpTravelTest()
        {
            IWebDriver driver = new ChromeDriver();



            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.phptravels.net/home";

            driver.FindElement(By.XPath("//a[text()='flights']")).Click();

            Thread.Sleep(30000);
            driver.FindElement(By.Id("autocomplete")).SendKeys("PNQ");
            driver.FindElement(By.XPath("//b[text()='PNQ']")).Click();
            driver.FindElement(By.Id("autocomplete2")).SendKeys("BBI");
            driver.FindElement(By.XPath("//b[text()='BBI']")).Click();
            driver.FindElement(By.Id("departure")).Clear();
            driver.FindElement(By.Id("departure")).SendKeys("30-01-2023");
            driver.FindElement(By.XPath("//p[contains(text(),'Travellers ')]")).Click();
            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();
            driver.FindElement(By.Id("flights-search")).Click();
            Thread.Sleep(30000);
            string printdetails = driver.FindElement(By.XPath("//div[@class='theme-search-results-item-preview']")).Text;
            Console.WriteLine(printdetails);

            driver.Quit();




        }





    }
}


