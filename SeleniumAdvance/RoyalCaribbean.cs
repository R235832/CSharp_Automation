using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SeleniumAdvance
{
    public class RoyalCaribbean
    {
        [Test]

        public static void Royal()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            // driver.Url = "https://www.royalcaribbean.com/";
            //// Thread.Sleep(20000);
            // driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();
            // driver.FindElement(By.Id("rciHeaderSignIn")).Click();
            // Thread.Sleep(30000);
            // driver.ExecuteJavaScript("document.querySelector(\"a[class~='login__create-account']\").click();\r\n");
            // driver.FindElement(By.PartialLinkText("Create an account")).Click();
            driver.Url = "https://www.royalcaribbean.com/account/create";
            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("john");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("setw");

            driver.FindElement(By.XPath("//span[normalize-space()='Month']")).Click();
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()='December']"))).Perform();
            driver.FindElement(By.XPath("//span[normalize-space()='December']")).Click();

          //  driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();

            driver.FindElement(By.XPath("//span[normalize-space()='Day']")).Click();
            Actions act1 = new Actions(driver);
            act1.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()=27]"))).Perform();
            driver.FindElement(By.XPath("//span[normalize-space()=27]")).Click();

         //   driver.FindElement(By.XPath("//span[normalize-space()=2]")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("2000");

            driver.FindElement(By.XPath("//span[normalize-space()='Country/Region of residence']")).Click();
            Actions act2 = new Actions(driver);
            act2.MoveToElement(driver.FindElement(By.XPath("//span[contains(text(),'India ')]"))).Perform();
            driver.FindElement(By.XPath("//span[contains(text(),'India ')]")).Click();

            //  driver.FindElement(By.XPath("//span[normalize-space()='United States of America' ]")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-0']")).Click();
            Actions act4 = new Actions(driver);
            act4.MoveToElement(driver.FindElement(By.XPath("//input[@id='mat-input-0']"))).Perform();
            driver.FindElement(By.XPath("//input[@id='mat-input-0']")).SendKeys("jo804@gmail.com");

            driver.FindElement(By.XPath("//input[@id='mat-input-4']")).SendKeys("john@198207");

            driver.FindElement(By.XPath("//div[@id='mat-select-value-7']")).Click();
            Actions act5 = new Actions(driver);
            act5.MoveToElement(driver.FindElement(By.XPath("//div[@id='mat-select-value-7']"))).Perform();
            driver.FindElement(By.XPath("//span[contains(text(),\"What was your first car's make or model? \")]")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-5']")).SendKeys("Amazing");
            driver.FindElement(By.XPath("//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin']")).Click();
            driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin'])[2]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),' Done ')]")).Click();












        }

    }
}
