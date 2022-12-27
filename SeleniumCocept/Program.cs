using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace SeleniumConcept
{
    public class program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://github.com/login";
            //  Console.WriteLine(driver.Title);
            //Console.WriteLine(driver.Url);
            // Console.WriteLine(driver.PageSource);
            driver.FindElement(By.Id("login_field")).SendKeys("ram");
            driver.FindElement(By.Id("password")).SendKeys("Password");
            driver.FindElement(By.Name("commit")).Click();


        }
    }
}
