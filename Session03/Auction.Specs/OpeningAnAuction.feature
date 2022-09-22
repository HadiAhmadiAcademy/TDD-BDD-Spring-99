Feature: Opening an Auction
	In order to sell my product at best price
	As a seller
	I want to be open an auction for my product


Scenario: Opening an auction successfully
	Given I have an active seller account
	When I open the auction for my product with following conditions
	| Product Name        | Starting Price | Active Period |
	| 'Laptop Asus N45JK' | 2000000        | 10 Days       |
	Then my auction is available in the list of open auctions

#Scenario: Placing the first
#	Given 'Jack' is a buyer
#	And I have opened the following auction
#	| Product Name        | Starting Price | Active Period |
#	| 'Laptop Asus N45JK' | 2000000        | 10 Days       |
#	And There is no bid
#	When 'Jack' places a bid with '2100000' amount
#	Then Price of auction changes to '2100000'
#	And 'Jack' promoted as current winner