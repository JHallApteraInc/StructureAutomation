Feature: Login
	As a Tester
	I want to login to Stucture
	So I can Test items

@Login
Scenario: Log into Structure
	Given I am on the login page for Structure
	And I have entered my username and password
	When I press sign in
	Then I should login and be redirected to the main page