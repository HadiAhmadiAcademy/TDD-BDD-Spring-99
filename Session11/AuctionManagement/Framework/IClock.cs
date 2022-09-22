using System;

namespace AuctionManagement.Framework
{
    public interface IClock
    {
        DateTime Now();
    }
}