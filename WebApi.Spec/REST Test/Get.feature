Feature: Get Product
	In order to view product details
	As a user
	I want to get a product by its id

@mytag
Scenario: Get Product
	Given I am at the home page want to see detail of 2
	When I click submit button
	Then the returned status code is success
	#And the response contains product details
	#	| Name  | Value    |
	#	| Id    | 2        |
	#	| Name  | Checkers |
	#	| Price | 5.99M    |


