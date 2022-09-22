using System;
using AuctionManagement.Framework;
using AuctionManagement.Tests.Unit;

namespace AuctionManagement
{
    public class Auction
    {
        public DateTime EndDateTime { get; private set; }
        public int StartingPrice { get; private set; }
        public Bid WinningBid { get; private set; }
        public Auction(DateTime endDateTime, int startingPrice, IClock clock)
        {
            if (clock.Now() > endDateTime) throw new InvalidEndDateException();

            EndDateTime = endDateTime;
            StartingPrice = startingPrice;
        }

        public void PlaceBid(Bid bid, IClock clock)
        {
            if (clock.Now() >= this.EndDateTime) throw new ExpiredAuctionException();
        }
    }
}
