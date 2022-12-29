using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium.AssignmentDaytwo
{
    public class GoTo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.goto.com/meeting";
            driver.FindElement(By.XPath("//button[@type=\"button\"]")).Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            try
            {
                action.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch
            {

            }
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Try Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("john");
            driver.FindElement(By.Id("last-name")).SendKeys("wick");
            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");
            SelectElement element = new SelectElement(driver.FindElement(By.Id("CompanySize")));
            element.SelectByText("10 - 99");
            try
            {
                action.ScrollToElement(driver.FindElement(By.XPath("//button[text()='Start My Trial']"))).Perform();
            }
            catch
            {

            }

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();
           // driver.FindElement(By.Name("")).Click();
            string error = driver.FindElement(By.XPath("//span[@class='inputField__subhead']")).Text;
            Console.WriteLine(error);
            
        }
    }
}
