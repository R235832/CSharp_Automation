using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace M.AssignmentDauyTwo
{
    public class Nasscom
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://nasscom.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//a[@data-fancybox=\"login-btn\"]")).Click();
            driver.FindElement(By.XPath("//li[@data_get=\"register-app\"]")).Click();
            driver.FindElement(By.XPath("//input[@id=\"edit-field-fname-reg-0-value\"]")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id=\"edit-field-lname-0-value\"]")).SendKeys("pass");
            driver.FindElement(By.XPath("//input[@id=\"edit-mail\"]")).SendKeys("admin@gmail.com");
            driver.FindElement(By.XPath("//input[@id=\"edit-field-company-name-registration-0-value\"]")).SendKeys("Goggle");
            SelectElement businessFocus = new SelectElement(driver.FindElement(By.XPath("//select[@id=\"edit-field-business-focus-reg\"]")));
            businessFocus.SelectByText("IT Consulting");
            driver.FindElement(By.XPath("//input[@id=\"edit-submit--2\"]")).Click();
        }
    }
}
