Feature: UserRegistration
	In order to use website's services
	As a user
	I want to be able to register


Scenario: User Registers
	When I attempt to register with following details
	| Username | Password |
	| Jack     | 123456   |
	Then I should be able to log in to the website
	And I should receive a welcome email