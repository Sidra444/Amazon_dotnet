using OpenQA.Selenium;

namespace AmazonTest.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private const string URL = "https://www.amazon.com/";
        private readonly By _searchBox = By.Id("twotabsearchtextbox");
        private readonly By _searchButton = By.Id("nav-search-submit-button");
        // private readonly By _AddtoCart = By.Id("a-autoid-1-announce");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl(URL);
            // _driver.Manage().Cookies.AddCookie(new Cookie("key", "value"));
        }

        public void Search(string searchTerm)
        {
            var searchitem = "TP-Link N450 WiFi Router";
            _driver.FindElement(_searchBox).SendKeys(searchitem);
            _driver.FindElement(_searchButton).Click();
            // _driver.FindElement(_AddtoCart).Click();
        }
    }
}
