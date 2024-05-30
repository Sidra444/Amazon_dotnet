using AmazonTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System;

using NUnit.Framework;

namespace AmazonTest.StepDefinitions
{
    [Binding]
    public class AmazonSearchSteps
    {
        private IWebDriver _driver;
        private HomePage _homePage;
        private SearchResultsPage _searchResultsPage;
        private ProductPage _productPage;
        private CartPage _cartPage;
        private string _ProductTitle;

        private string _expectedTitle;
        private string _expectedPrice;


        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _homePage = new HomePage(_driver);
            _searchResultsPage = new SearchResultsPage(_driver);
            _productPage = new ProductPage(_driver);
            _cartPage = new CartPage(_driver);
        }

        [Given("I am on the Amazon home page")]
        public void GivenIAmOnTheAmazonHomePage()
        {
            _homePage.Open();

            HandleCaptchaManually();
        }

        private void HandleCaptchaManually()
        {
            Console.WriteLine("Please solve the CAPTCHA if prompted.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Continuing with the test execution...");
            System.Threading.Thread.Sleep(5000); // Add additional wait time if needed
        }


        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            _homePage.Search(searchTerm);
        }

        [When("I add the first item from search result to the cart")]
        public void WhenISelectFirstElementandADDtoCart()
        {
            _expectedTitle = _searchResultsPage.GetFirstSearchResultTitle();
            _searchResultsPage.SelectFirstResult();
            string productTitle = _productPage.GetProductTitle();
            Console.WriteLine($"Product title: {productTitle}");
            _productPage.AddToCart();
            // _productPage.NavigatetoCartPage();

        }

        [When("I Navigate to the Cart")]
        public void WhenINavigateToCart()
        {
            _productPage.NavigatetoCartPage();
        }

        [Then("I should see Expected title of product in the cart")]
        public void VerifyProductItem(string expectedTitle, string _expectedPrice)
        {
            string actualTitle = _cartPage.GetCartItemTitle();
            string actualPrice = _cartPage.GetCartItemAmount();

            Assert.Equals(expectedTitle, actualTitle);
            Assert.Equals(_expectedPrice, actualPrice);
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
