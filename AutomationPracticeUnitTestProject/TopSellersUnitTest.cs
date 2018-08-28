using AutomationPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPracticeUnitTestProject
{
    [TestClass]
    public class TopSellersUnitTest
    {
        [TestMethod]
        public void TopSellers()
        {
            var c = new TopSellers();
            c.Go();
        }
    }
}
