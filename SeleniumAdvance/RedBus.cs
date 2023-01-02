using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class RedBus
    {
        [Test]
        public void BookTicket()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.redbus.in/";
            driver.FindElement(By.Id("i-icon-profile")).Click();
            driver.FindElement(By.Id("signInLink")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("7898");
            string errorMessage = driver.FindElement(By.XPath("//span[@class='error-message-fixed error-message-full top-fix']")).Text;
            Console.WriteLine(errorMessage);
        }
    }
}
