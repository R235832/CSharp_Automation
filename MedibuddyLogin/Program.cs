using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.AssignmentDaytwo
{
    public class MediBudy
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.medibuddy.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            driver.FindElement(By.XPath("//a[@ng-if=\"!OneClickFlowLogin && !flashbooking\"]")).Click();
            driver.FindElement(By.XPath("//div[@ng-click=\"linkAccount()\"]")).Click();
            driver.FindElement(By.XPath("//div[@ng-click=\"openLoginScreenOld(false, 'USER_NAME_PWD_SCREEN')\"]")).Click();
            driver.FindElement(By.Name("userName")).SendKeys("John");
            driver.FindElement(By.XPath("//button[@type=\"submit\"]")).Click();
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.XPath("//input[@ng-checked=\"false\"]")).Click();
            driver.FindElement(By.XPath("//button[@type=\"submit\"]")).Click();
            string errormessage = driver.FindElement(By.XPath("//*[contains(text(),'incorrect')]")).Text;
            Console.WriteLine(errormessage);
            //driver.FindElement(By.XPath("")).Click();
        }
    

}
    
}

