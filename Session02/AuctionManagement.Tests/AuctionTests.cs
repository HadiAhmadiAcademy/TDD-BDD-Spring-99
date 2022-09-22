using System;
using AuctionManagement.Tests.TestBuilders;
using FluentAssertions;
using Xunit;
using static AuctionManagement.Tests.TestBuilders.TestConstants;

namespace AuctionManagement.Tests
{
    public class AuctionTests
    {
        [Fact]
        public void auction_opens_with_valid_data()
        {
            var sellerId = 1;
            var endDateTime = DateTime.Now.AddDays(1);
            var product = "ASUS N56JK";
            var startingPrice = 1000;

            var auction = new Auction(sellerId, endDateTime, product, startingPrice);

            auction.SellerId.Should().Be(sellerId);
            auction.EndDateTime.Should().Be(endDateTime);
            auction.Product.Should().Be(product);
            auction.StartingPrice.Should().Be(startingPrice);
        }

        [Fact]
        public void auction_cant_be_open_when_ending_is_past()
        {
            var sellerId = 1;
            var endDateTime = DateTime.Now.AddDays(-1);
            var product = "ASUS N56JK";
            var startingPrice = 1000;

            Action openingAuction = () => new Auction(sellerId, endDateTime, product, startingPrice);

            openingAuction.Should().Throw<InvalidEndDateException>();
        }

        [Fact]
        public void auction_opens_with_no_winner_at_the_beginning()
        {
            var sellerId = 1;
            var endDateTime = DateTime.Now.AddDays(1);
            var product = "ASUS N56JK";
            var startingPrice = 1000;

            var auction = new Auction(sellerId, endDateTime, product, startingPrice);

            auction.WinningBid.Should().Be(null);
        }

        [Fact]
        public void bid_places_as_current_winner_when_bid_is_greater_than_starting_price_on_first_bid()
        {
            var auction = new AuctionTestBuilder().WithStartingPrice(1000).Build();
            var bid = new Bid(1100,2);

            auction.PlaceBid(bid);

            auction.WinningBid.Should().Be(bid);
        }

        [Theory]
        [InlineData(1000, 1000)]
        [InlineData(999, 1000)]
        public void bid_not_place_when_bid_is_not_greater_then_starting_price_on_first_bid(int bidAmount, int startingPrice)
        {
            var auction = new AuctionTestBuilder().WithStartingPrice(startingPrice).Build();
            var bid = BidTestFactory.CreateWithAmount(bidAmount);

            Action placingBid = ()=> auction.PlaceBid(bid);

            placingBid.Should().Throw<InvalidBidAmountException>();
        }

        [Fact]
        public void seller_cant_place_bid_on_himself_auction()
        {
            var auction = new AuctionTestBuilder().WithSeller(Sellers.Jack).Build();
            var bid = BidTestFactory.CreateWithBidder(Sellers.Jack);

            Action placeBid = () => auction.PlaceBid(bid);

            placeBid.Should().Throw<InvalidBidderException>();
        }
    }
}
