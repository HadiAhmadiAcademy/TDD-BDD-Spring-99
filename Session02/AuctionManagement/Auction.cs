using System;
using AuctionManagement.Tests;

namespace AuctionManagement
{
    public class Auction
    {
        public int SellerId { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Product { get; set; }
        public int StartingPrice { get; set; }
        public Bid WinningBid { get; set; }

        public Auction(int sellerId, DateTime endDateTime, string product, int startingPrice)
        {
            if (endDateTime < DateTime.Now) throw new InvalidEndDateException();

            SellerId = sellerId;
            EndDateTime = endDateTime;
            Product = product;
            StartingPrice = startingPrice;
        }

        public void PlaceBid(Bid bid)
        {
            if (this.SellerId == bid.BidderId) throw new InvalidBidderException();
            if (bid.Amount <= this.StartingPrice) throw new InvalidBidAmountException();

            this.WinningBid = bid;
        }
    }
}