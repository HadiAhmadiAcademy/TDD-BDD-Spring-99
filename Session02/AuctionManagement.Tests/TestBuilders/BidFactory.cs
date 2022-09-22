using static AuctionManagement.Tests.TestBuilders.TestConstants;

namespace AuctionManagement.Tests.TestBuilders
{
    internal class BidTestFactory
    {
        public static Bid CreateWithAmount(int amount)
        {
            return new Bid(amount, Bidders.Sarah);
        }

        public static Bid CreateWithBidder(int bidderId)
        {
            return new Bid(int.MaxValue, bidderId);
        }
    }
}