using System;
using AuctionManagement.Tests.Unit.Steps;
using FluentAssertions;
using TestStack.BDDfy;
using Xunit;
using static AuctionManagement.Tests.Unit.Utils.TestConstants.Sellers;

namespace AuctionManagement.Tests.Unit.Specs
{
    public class PlacingFirstBidOnAuction
    {
        private AuctionSteps _steps;
        public PlacingFirstBidOnAuction()
        {
            this._steps = new AuctionSteps();    
        }

        [Fact]
        public void bid_amount_must_be_greater_than_starting_price()
        {
            this.Given(a => _steps.ThereIsAnAuction(z=> z.WithStartingPrice(100)))
                .When(a => _steps.SomeoneAttemptsToPlaceABidWithAmount(900))
                .Then(a => _steps.HeGetsAnErrorOfType<InvalidBidAmountException>())
                .BDDfy();
        }

        [Fact]
        public void seller_cant_place_bid_on_his_own_auction()
        {
            //this.Given(a => _steps.ThereIsAnAuction(z=>z.WithSeller(Jack)))
            //    //.When(a=> a._steps)
            //    //.Then(a => _steps.HeGetsAnErrorOfType<InvalidBidAmountException>())
            //    .BDDfy();
        }
    }
}
