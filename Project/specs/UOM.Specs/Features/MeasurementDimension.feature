Feature: Managing Measurement Dimensions
	In order to categorize unit of measures and convert them to each other only in their dimension
	As a procurement manager
	I want to be able to define measurement dimensions

#@API-Level
@UI-Level
Scenario: Defining dimension
	Given I have entered as procurement manager account
	When I define the following dimension
	| Name | Symbol |
	| Mass | m      |
	Then I should be able to see the dimension in the list of dimensions

