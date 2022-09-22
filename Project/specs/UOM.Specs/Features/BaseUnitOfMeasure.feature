Feature: Base Unit of Measures
	In order to convert unit of measures to each other without defining the conversion rate for every single unit
	As a procument manager
	I want to be able to define a base unit of measure for a dimension

Scenario: Defining a base unit of measure
	Given I have already defined the 'Mass' as a dimension
	When I define the following base unit of measure
	| Name | Symbol |
	| Gram | gr     |
	And Assign it to 'Mass' dimension
	Then 'Gram' is the base unit of measure of 'Mass'


@Sandbox
Scenario: Defining more than one base unit of measure for a dimension
	Given I have already defined the 'Mass' as a dimension
	And I have already defined the 'gram' as a base unit of measure for 'Mass'
	When I define the following base unit of measure
	| Name     | Symbol |
	| Kilogram | kg     |
	And Assign it to 'Mass' dimension
	Then I should get an error saying that 'The dimension already has a base unit of measure'