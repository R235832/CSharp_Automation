using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstDaySeleniumassignment
{
    public class GuruDemoRegister
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            driver.FindElement(By.Name("firstName")).SendKeys("Virat");
            driver.FindElement(By.Name("lastName")).SendKeys("Kohli");
            driver.FindElement(By.Name("phone")).SendKeys("6230912875");
            driver.FindElement(By.Id("userName")).SendKeys("virat@gmail.com");
            driver.FindElement(By.Name("address1")).SendKeys("Amritsar");
            driver.FindElement(By.Name("city")).SendKeys("Amritsar");
            driver.FindElement(By.Name("state")).SendKeys("Punjab");
            driver.FindElement(By.Name("postalCode")).SendKeys("541209");
            driver.FindElement(By.Id("email")).SendKeys("Virat12");
            driver.FindElement(By.Name("password")).SendKeys("Virat@123");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("Virat@123");
            driver.FindElement(By.Name("submit")).Click();
        }
    }
}