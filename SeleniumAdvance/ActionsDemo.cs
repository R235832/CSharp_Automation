using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace SeleniumAdvance
{
    public class ActionsDemo
    {
        [Test]
        public void NasscomTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://nasscom.in/about-us/contact-us";
            //Thread.Sleep(2000);
           // driver.FindElement(By.XPath("//div[@class='fancybox-toolbar']")).Click();
            Actions acttion = new Actions(driver);
            acttion.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Build().Perform();
            driver.FindElement(By.XPath("//a[text()='Become a Member']")).Click();
        }
        [Test]
        public void demo2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.google.com/";
            Actions action=new Actions(driver);
            action.KeyDown(Keys.Shift).SendKeys("virat").KeyUp(Keys.Shift).SendKeys(Keys.ArrowDown)
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Build().Perform();  

        }
    }
}
