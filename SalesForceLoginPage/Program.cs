using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstDaySeleniumAssignment
{
    public class Sales
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            driver.FindElement(By.Name("UserTitle")).Click();
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");
            driver.FindElement(By.Name("CompanyEmployees")).Click();
            driver.FindElement(By.Name("CompanyCountry")).Click();
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();

        }
    }
}