Feature: Cart

As a user, I will like to add items to my cart, view items in my cart, search and delete the lowest price item from in the cart

@regression
Scenario: Test_01 Test to ensure that a user can add items to the cart, search and delete items in the cart
	Given the application is up and running
	And I added four random items to my cart
	When I view my cart
	Then I find total four items listed in my cart
	When I search for lowest price item
	And I am able to remove the lowest price Item from my cart
	Then I am able to verify three items in my cart
