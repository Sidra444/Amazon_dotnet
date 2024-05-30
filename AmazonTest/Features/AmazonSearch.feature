Feature: Amazon Search and Add to Cart
  Scenario: Search for a product and add to cart
    Given I am on the Amazon home page
    When I search for "TP-Link N450 WiFi Router"
    When I add the first item from search result to the cart
    When I Navigate to the Cart
    Then I should see the expected title and price of the product in the cart
