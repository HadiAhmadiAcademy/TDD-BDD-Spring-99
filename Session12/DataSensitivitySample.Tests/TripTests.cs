using System;
using System.Linq;
using FizzWare.NBuilder;
using FluentAssertions;
using Xunit;

namespace DataSensitivitySample.Tests
{
    public class TripTests
    {
        [Fact]
        public void cant_add_passengers_more_than_limitation()
        {
            var trip = new Trip();
            var currentPassengers = CreatePassengersOfSize(Trip.MaximumNumbersOfTravelers);
            trip.AddPassenger(currentPassengers);

            Action addingPassenger = ()=> trip.AddPassenger("hadi");

            addingPassenger.Should().Throw<Exception>();
        }

        private string[] CreatePassengersOfSize(int count)
        {
            return null;
        }
    }
}
