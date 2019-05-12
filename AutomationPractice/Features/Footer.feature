Feature: Footer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: User can open links under Information section
	When user clicks on '<information link>' option
	Then correct '<page>' is displayed
Examples: 
	| information link            | page			|
	| Specials                    | Price drop      |
	| New products                | New products    |
	| Best sellers                | Best sellers    |
	| Our stores                  | Our store	    |
	| Contact us                  | Contact		    |
	| Terms and conditions of use | Terms and conditions of use     |
	| About us                    | About us	    |
	| Sitemap                     | Sitemap         |


Scenario Outline: User can open links under My Acount Information section
	Given user opens sign in page
	And enters correct credentials 
	And user submits the login form
	When user clicks on '<link>' under My Account section
	Then correct '<page>' under My Account section is displayed
Examples: 
	| link					         | page                      |
	| My orders                      | Order history             |
	| My credit slips                | Credit slips              |
	| My addresses                   | My addresses              |
	| Manage my personal information | Your personal information |
	
