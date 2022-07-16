using System;
using TechTalk.SpecFlow;
using StockApp;

namespace BlogDemo.StepDefinitions
{
    [Binding]
    public class AsAStockAppUserIWantToPurchaseAGivenStepDefinitions
    {
        public StockAppClass stockApp = new StockAppClass();

        [Given(@"That I am a StockApp User")]
        public void GivenThatIAmAStockAppUser()
        {
            stockApp.User = "DemoUser";
            stockApp.SetJSonValue("Defining Start");
        }

        [Given(@"My initial portfolio has a value of ""([^""]*)""")]
        public void GivenMyInitialPortfolioHasAValueOf(string portfolioValue)
        {
            stockApp.SetPortfolioValue(int.Parse(portfolioValue));
            stockApp.SetJSonValue("In body area 1");
        }

        [When(@"I purchase ""([^""]*)"" amount of ""([^""]*)"" at the latest value")]
        public void WhenIPurchaseAmountOfAtTheLatestValue(string amount, string stockCode)
        {
            stockApp.PurchaseStock(amount, stockCode);
            stockApp.SetJSonValue("In body area 2");
        }

        [Then(@"My portfolio ""([^""]*)"" has increased in value")]
        public void ThenMyPortfolioHasIncreasedInValue(string portfolioValue)
        {
            int initialPortfolioValue = Int32.Parse(portfolioValue);
            int newPortfolioValue = stockApp.PortfolioValue;
            newPortfolioValue.Should().BeGreaterThan(initialPortfolioValue);
            stockApp.SetJSonValue("Defining End");
            Console.WriteLine(stockApp.JSonValue);

        }
    }
}
