using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Ma.AssignmentDayTwo
{
    public class Oracle
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.oracle.com/in/database/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//button[@data-lbl=\"sign-in-account\"]")).Click();
            driver.FindElement(By.XPath("//a[@data-lbl=\"profile:sign-in-account\"]")).Click();
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(By.XPath("//h2[contains(text(),'Oracle account sign in')]"));
            string text=element.Text;
            Console.WriteLine(text);
            driver.FindElement(By.Name("ssousername")).SendKeys("john");
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.XPath("//input[@id=\"signin_button\"]")).Click();
            Thread.Sleep(1000);
            string errorMessage= driver.FindElement(By.XPath("//span[@id=\"errormsg\"]")).Text;
            Console.WriteLine(errorMessage);
        }
    }
}
