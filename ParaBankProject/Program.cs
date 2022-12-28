using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace M.ParaBank
{ 
    public class ParaBank
    {
        static void Main(string[] args)
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Rakesh");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("Rout");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("Jenapur");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("Jajpur");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Odisha");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("755023");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("9938908328");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("982");
            driver.FindElement(By.Id("customer.username")).SendKeys("Rakro");
            driver.FindElement(By.Id("customer.password")).SendKeys("Rak@123");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("Rak@123");
            driver.FindElement(By.XPath("(//input[@class=\"button\"])[2]")).Click();


        }

    }
}
