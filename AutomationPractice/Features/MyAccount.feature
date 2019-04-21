Feature: MyAccount
	Inorder to use all functionalities
	As a user
	I want to be able to manage my account

@MyAccomunt
Scenario: User can log in
	Given user opens sign in page
	And enters correct credentials 
	When user submits the login form
	Then user will be logged in

@MyAccomunt
Scenario: User can open wishlist page
	Given user opens sign in page
	And enters correct credentials 
	And user submits the login form
	When user opens my wishlist
	Then user can add new wishlist

@MyAccomunt
Scenario: User can create an accout
	Given user opens sign in page
	And initiates a flow for creating an account
	And user enters all required personal details
	When submits the sign up form
	Then user will be logged in
	And user's full name is displayed

@MyAccomunt  //napravi novi feature
Scenario: User can search for a product and add it to the cart
    Given user enters a DRESS search term
    And user submits the search
    And opens first product from the list
    When user clicks on add to cart button
    And user proceeds to checkout
    Then cart page is opened 
	
