using System;
using static AuctionManagement.Tests.TestBuilders.TestConstants;

namespace AuctionManagement.Tests.TestBuilders
{
    internal class AuctionTestBuilder
    {
        private int _sellerId = Sellers.Jack;
        private int _startingPrice = 1000;
        private DateTime _endDateTime = DateTime.Now.AddDays(1);
        private string _product = "ASUS N56JK";
        public AuctionTestBuilder WithSeller(int sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }
        public AuctionTestBuilder WithStartingPrice(int startingPrice)
        {
            this._startingPrice = startingPrice;
            return this;
        }
        public Auction Build()
        {
            return new Auction(_sellerId, this._endDateTime, this._product, this._startingPrice);
        }

    }
}