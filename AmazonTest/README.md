# Amazon Test Automation Testing using Selenium WebDriver C#

This is an automation technical task to automate search of a TP-Link wifi router, Add To Cart and assert title and it's price.

## Test Flow
Scenario: Search for a product and add to cart
 - Navigate to https://www.amazon.com/
 - After navigation to URL, handled CAPTCHA manually first it will solve the CAPTCHA manually than Press Enter in terminal and than test execution will be resumed
 - Type in “TP-Link N450 WiFi Router” in the search text box (HomePage.cs)
 - Click on “Search” button (SearchResultPage.cs)
 - Click on the first result 
 - Addto cart product from product page (ProductPage.cs)
 - Click on cart icon to navigate to the cart page 
 - Upon page navigation, validate the correct item and amount of the product is displaying on cart page

## Project Setup
 - Create a unit test C# project using VS Code
  - Using NuGet, find and install Selenium WebDriver
 dotnet new nunit -n AmazonTest
 cd AmazonTest
 dotnet add package SpecFlow.NUnit
 dotnet add package SpecFlow.Tools.MsBuild.Generation
 dotnet add package Selenium.WebDriver
 dotnet add package Selenium.WebDriver.ChromeDriver
 dotnet add package SpecFlow.Selenium

## Implementation Decision:
  - Page Object Model - each page of the application within the scope is represented by one class.
  - Use different element locators -- id, name, cssSelector and XPath
  - Single Responsibility Principle - creates an application class that handles user behavior. 
  - Test Case - add a test case that asserts ttitle and price as expected.
  
## Run the test
 - Enter 'dotnet test' in the terminal to run the test script
