Feature: As a StockApp User I want to purchase a given

A short summary of the feature

@tag1
@DataSource:StockValues.xlsx
Scenario: As a StockApp user I want to purchase a given amount of stock at the latest value so that I can increase the value of my portfolio
	Given That I am a StockApp User
	And My initial portfolio has a value of "<InitialPortfolioValue>"
	When I purchase "<AmountStockToBuy>" amount of "<StockCode>" at the latest value
	Then My portfolio "<InitialPortfolioValue>" has increased in value

