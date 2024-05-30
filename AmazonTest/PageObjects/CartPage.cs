using OpenQA.Selenium;
using System.Linq;
using System.Xml;

namespace AmazonTest.PageObjects
{
    public class CartPage
    {
        private readonly IWebDriver _driver;
        // private readonly By _cartButton = By.ClassName("nav-cart-icon nav-sprite");
        private readonly By _cartButton = By.Id("nav-cart-count");
        private readonly By _cartItems = By.Id("productTitle");
        // private readonly By_cartprice = By.class("a-price-whole");
        

        private readonly By _CartItemTitle = By.XPath("//span[@class='a-size-base-plus a-color-base sc-product-title sc-grid-item-product-title']");
        private readonly By _CartItemAmount = By.XPath("//span[@class='a-size-medium a-color-base sc-price sc-white-space-nowrap sc-product-price a-text-bold']");


        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenCart()
        {
            _driver.FindElement(_cartButton).Click();
        }
        public string GetCartItemTitle()
        {
            return _driver.FindElement(_CartItemTitle).Text;
        }

        public string GetCartItemAmount()
        {
            return _driver.FindElement(_CartItemAmount).Text;
        }

        public void VerifyProductItem()
        {
            var title = GetCartItemTitle();
            var price = GetCartItemAmount();
        }
        
    }
}



