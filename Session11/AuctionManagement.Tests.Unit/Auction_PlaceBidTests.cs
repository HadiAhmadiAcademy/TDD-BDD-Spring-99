using System;
using System.Threading;
using AuctionManagement.Tests.Unit.TestDoubles;
using FluentAssertions;
using Xunit;

namespace AuctionManagement.Tests.Unit
{
    public class AuctionTests
    {
        [Fact]
        public void cant_open_auction_with_past_end_date()
        {
            Action openingAnAuction = ()=> new Auction(DateTime.Now.AddDays(-1), 1000, StubClock.Default());

            openingAnAuction.Should().Throw<InvalidEndDateException>();
        }

        [Fact]
        public void cant_place_bid_on_expired_auction()
        {
            var clock = StubClock.WhichSetsNowAs(DateTime.Parse("2010-01-01 10:30"));
            var endDate = DateTime.Parse("2010-02-01 10:30");
            var auction = new Auction(endDate, 1000, clock);
            clock.TimeTravelToSomeDateAfter(endDate);

            var bid = new Bid();

            Action placingBid = () => auction.PlaceBid(bid, clock);

            placingBid.Should().Throw<ExpiredAuctionException>();
        }
    }
}
