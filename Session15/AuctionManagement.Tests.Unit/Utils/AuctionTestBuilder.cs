using System;

namespace AuctionManagement.Tests.Unit.Utils
{
    public class AuctionTestBuilder
    {
        private int _sellerId = TestConstants.Sellers.Jack;
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