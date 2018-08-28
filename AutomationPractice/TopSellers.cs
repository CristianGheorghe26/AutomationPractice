using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice
{
    public class TopSellers
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com");
            driver.FindElement(By.XPath("//*[@id='search_query_top']")).SendKeys("T-shirts");
            driver.FindElement(By.XPath("//*[@id='searchbox']/button")).Click();
            driver.FindElement(By.XPath("//*[@id='best-sellers_block_right']/h4/a")).Click();
            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a/i")).Click();
            driver.Quit();
        }
    }
}
