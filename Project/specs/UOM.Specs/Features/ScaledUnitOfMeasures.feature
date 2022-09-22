Feature: Scaled Unit of measures
	In order to convert unit of measures that are convertable to base with a conversion rate
	As a procument manager
	I want to be able to define scaled unit of measures

Background: 
	Given I have defined the 'Mass' as a dimension

Scenario: Defining a scaled unit of measure
	Given I have defined the 'Gram' as a base unit of measure for 'Mass'
	When I define the following scaled unit of measure
	| Name     | Symbol | Dimension | ConversionRate |
	| Kilogram | KG     | Mass      | 1000           |
	Then I should be able to see 'Kilogram' in the list of unit of measures of 'Mass'

Scenario: Converting a scaled unit of measure to base
	Given I have defined the 'Gram' as a base unit of measure for 'Mass'
	And I have defined the following scaled unit of measure
	| Name     | Symbol | Dimension | ConversionRate |
	| Kilogram | KG     | Mass      | 1000           |
	When I convert the '20KG' to 'Gram'
	Then The result should be '20000'


Scenario: Converting a scaled unit of measure to another
	Given I have defined the 'Gram' as a base unit of measure for 'Mass'
	And I have defined the following scaled unit of measure
	| Name     | Symbol | Dimension | ConversionRate |
	| Kilogram | KG     | Mass      | 1000           |
	And I have defined the following scaled unit of measure
	| Name  | Symbol | Dimension | ConversionRate |
	| Tonne | TN     | Mass      | 1000000        |
	When I convert the '20TN' to 'Kilogram'
	Then The result should be '20000'