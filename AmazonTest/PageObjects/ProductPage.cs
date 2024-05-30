using OpenQA.Selenium;

namespace AmazonTest.PageObjects
{
    public class ProductPage
    {
        private readonly IWebDriver _driver;
        
        // private readonly By _ProductTitle = By.Id("productTitle");
        private By ProductTitleLocator = By.XPath("//span[@id='productTitle']");
        private readonly By _addToCartButton = By.Id("add-to-cart-button");
        private readonly By _cartButton = By.Id("nav-cart-count");

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetProductTitle()
        {
            IWebElement productTitleElement = _driver.FindElement(ProductTitleLocator);
            return productTitleElement.Text;
        }

        public void AddToCart()
        {
            _driver.FindElement(_addToCartButton).Click();
        }

        public void NavigatetoCartPage()
        {
            _driver.FindElement(_cartButton).Click();
        }
    }
}
