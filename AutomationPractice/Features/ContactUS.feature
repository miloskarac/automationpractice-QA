Feature: Contact Us
	In order to contact coustomer service
	As usser 
	I want to be able send a message on site

@mytag
Scenario: User can contact support
	Given User opens a contact page
	And User enters all required  details
	When User send the message
	Then Message has been sent 
