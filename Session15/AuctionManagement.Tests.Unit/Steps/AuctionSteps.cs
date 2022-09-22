using System;
using AuctionManagement.Tests.Unit.Utils;
using FluentAssertions;

namespace AuctionManagement.Tests.Unit.Steps
{
    public class AuctionSteps
    {
        private Auction auction;
        private Action placeBid;
        //public void ThereIsAnAuctionWithStartingPrice(int startingPrice)
        //{
        //    auction = new Auction(1, DateTime.Now.AddDays(10), " X ", startingPrice);
        //}
        public void ThereIsAnAuction(Action<AuctionTestBuilder> builderConfigurator)
        {
            var builder = new AuctionTestBuilder();
            builderConfigurator.Invoke(builder);
            auction = builder.Build();
        }

        public void SomeoneAttemptsToPlaceABidWithAmount(int bidAmount)
        {
            var bid = new Bid(bidAmount, 2);
            placeBid = () => auction.PlaceBid(bid);
        }
        public void HeGetsAnErrorOfType<TException>() where TException : Exception
        {
            placeBid.Should().Throw<TException>();
        }
    }
}