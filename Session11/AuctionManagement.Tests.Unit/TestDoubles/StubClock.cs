using System;
using System.Runtime.CompilerServices;
using AuctionManagement.Framework;

namespace AuctionManagement.Tests.Unit.TestDoubles
{
    public class StubClock : IClock
    {
        private DateTime _now;
        //public StubClock() : this(DateTime.Now){ }
      
        public static StubClock WhichSetsNowAs(DateTime datetime)
        {
            return new StubClock(datetime);
        }

        public static StubClock Default()
        {
            return new StubClock(DateTime.Now);
        }
        private StubClock(DateTime now)
        {
            _now = now;
        }

        public DateTime Now() => _now;
        public void TimeTravelTo(DateTime target)
        {
            this._now = target;
        }
        public void TimeTravelToSomeDateAfter(DateTime date)
        {
            _now = date.AddDays(1);
        }
        public void TimeTravelToSomeDateBefore(DateTime date)
        {
            _now = date.AddDays(-1);
        }
    }
}