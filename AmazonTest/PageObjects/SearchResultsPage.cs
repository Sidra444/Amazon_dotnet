using OpenQA.Selenium;
using System.Linq;

namespace AmazonTest.PageObjects
{
    public class SearchResultsPage
    {
        private readonly IWebDriver _driver;
        private readonly By _results = By.XPath("//span[@class='a-size-medium a-color-base a-text-normal']");
        // private readonly By _AddtoCart = By.Id("add-to-cart-button");
        private readonly By _FirstResult = By.XPath("//span[@class='a-size-medium a-color-base a-text-normal']");

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetFirstSearchResultTitle()
        {
            return _driver.FindElement(_FirstResult).Text;
        }

        public void SelectFirstResult()
        {
            
            var results = _driver.FindElements(_results);
            if (results.Count > 0)
            {
                results.First().Click();
                
                
            }
            // _driver.FindElement(_AddtoCart).Click();
            
        }
    }
}
