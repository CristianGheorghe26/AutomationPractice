using AutomationPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPracticeUnitTestProject
{
    [TestClass]
    public class SortingSearchResultsUnitTest
    {
        [TestMethod]
        public void SortingSearchResults()
        {
            var c = new SortingSearchResults();
            c.Go();
        }
    }
}
