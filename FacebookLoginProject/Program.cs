using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstDaySeleniumassignment
{
    public class Facebookloginpage
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/signup";
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            driver.FindElement(By.Name("firstname")).SendKeys("john");
            
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            
            driver.FindElement(By.Name("reg_email__")).SendKeys("demo123@gmail.com");
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("demo123@gmail.com");
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("welcome 123");
            driver.FindElement(By.Name("birthday_day")).Click();
           
            driver.FindElement(By.Name("birthday_month")).Click();
            driver.FindElement(By.Name("birthday_year")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("sex")).Click();
            driver.FindElement(By.Name("websubmit")).Click();
        }
    }
}