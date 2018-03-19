Feature: AccessDevExpress
	In order to verify that dev express is working
	As a tester
	I want access a report and customize it

@CustomizeReport
Scenario: Customize a Report
	Given I have logged in
	And I am on the Reports page
	When I attempt to customize a report
	Then the result is that I do not see an awkward error
