using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice
{
    public class SortingSearchResults
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com");
            driver.FindElement(By.XPath("//*[@id='search_query_top']")).SendKeys("summer dresses");
            driver.FindElement(By.XPath("//*[@id='searchbox']/button")).Click();

            var productsort1 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort1 = new SelectElement(productsort1);
            select_productsort1.SelectByValue("position:asc");

            var productsort2 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort2 = new SelectElement(productsort2);
            select_productsort2.SelectByValue("price:asc");

            var productsort3 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort3 = new SelectElement(productsort3);
            select_productsort3.SelectByValue("price:desc");

            var productsort4 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort4 = new SelectElement(productsort4);
            select_productsort4.SelectByValue("name:asc");

            var productsort5 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort5 = new SelectElement(productsort5);
            select_productsort5.SelectByValue("name:desc");

            var productsort6 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort6 = new SelectElement(productsort6);
            select_productsort6.SelectByValue("quantity:desc");

            var productsort7 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort7 = new SelectElement(productsort7);
            select_productsort7.SelectByValue("reference:asc");

            var productsort8 = driver.FindElement(By.XPath("//*[@id='selectProductSort']"));
            var select_productsort8 = new SelectElement(productsort8);
            select_productsort8.SelectByValue("reference:desc");

            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a/i")).Click();
            driver.Quit();
        }
    }
}
