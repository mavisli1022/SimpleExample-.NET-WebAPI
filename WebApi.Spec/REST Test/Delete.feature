Feature: Delete one item
	As a user
	I want to delete a product by its id

@mytag
Scenario: Delete Product
	Given I am at the home page want to delete item of id 3
	When I click delete button
	Then the returned status code is deleted
