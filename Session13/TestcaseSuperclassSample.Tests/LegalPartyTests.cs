using System;
using FluentAssertions;
using Xunit;

namespace TestcaseSuperclassSample.Tests
{
    //public class DummyParty : Party { }

    public abstract class PartyTests
    {
        [Fact]
        public void assign_address_to_party()
        {
            var party = CreateParty();

            party.AddAddress("Tehran");

            party.Addresses.Should().HaveCount(1).And.Contain("Tehran");
        }

        protected abstract Party CreateParty();
    }
    public class LegalPartyTests : PartyTests
    {
        protected override Party CreateParty()=> new LegalParty();
    }
    public class IndividualPartyTests : PartyTests
    {
        protected override Party CreateParty()=> new IndividualParty();
    }
}
