Feature: Products
	As a user 
	I want to be able to work with Products section
	So I can choose products based on the selected term

@mytag
Scenario: The search title is displayed on the page
	Given user opens products page
	When user enters search product
		And user clicks on the search field
	Then user will see the title message 'Searched Products' on the search product page

Scenario: User can add product to a cart
	Given user opens products page
	When user enters search product
		And user clicks on the search field
		And opens first search result
		And user clicks on Add to Cart buton
		And proceeds to the cart
	Then shopping cart will be displayed expected product inside