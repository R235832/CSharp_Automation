using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace FirstDaySeleniumAssignment
{
    public class Sales
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            SelectElement selectjobtitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectjobtitle.SelectByText("IT Manager");  
            driver.FindElement(By.Name("CompanyName")).SendKeys("MavericSystems");
            SelectElement selectemployee = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectemployee.SelectByText("101 - 500 employees");     
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
            string error= driver.FindElement(By.XPath("//span[text()=\"Enter a valid phone number\"]")).Text;
            Console.WriteLine(error);


        }
    }
}