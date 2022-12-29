using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.AssignmentDaytwo
{
    public class GoTo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            driver.FindElement(By.XPath("//button[@type=\"button\"]")).Click();
            driver.FindElement(By.XPath("//div[@class=\"go-hero__cta-wrapper \"]"));
            driver.FindElement(By.XPath("//a[@data-cta-name=\"Try Free\"]")).Click();
        }
    }
}
