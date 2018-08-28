using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationPractice;

namespace AutomationPracticeUnitTestProject
{
    [TestClass]
    public class NegativeSearchUnitTest
    {
        [TestMethod]
        public void NegativeSearch()
        {
            var c = new NegativeSearch();
            var hasError = c.Go();
            Assert.IsTrue(hasError, "No results were found for your search");
        }
    }
}