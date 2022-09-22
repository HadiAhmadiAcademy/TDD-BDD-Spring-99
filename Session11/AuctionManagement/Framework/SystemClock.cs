using System;

namespace AuctionManagement.Framework
{
    public class SystemClock : IClock
    {
        public DateTime Now() => DateTime.Now;
    }
}