using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice
{
    public class NegativeSearch
    {
        public bool Go()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com");
            driver.FindElement(By.XPath("//*[@id='search_query_top']")).SendKeys("socks");
            driver.FindElement(By.XPath("//*[@id='searchbox']/button")).Click();
            var elem = driver.FindElementByClassName("alert-warning");
            var hasErrorAttribute = elem != null;
            driver.Quit();

            return hasErrorAttribute;
        }
    }
}