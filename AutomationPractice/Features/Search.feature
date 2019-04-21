Feature: Search
	in order to find product
	As a user	
	I want to be able to search for term

@Search
Scenario: User can search for term
	Given user enters 'dress' search term
	When user submits the search
	Then result for a 'dress' search term are displayed
