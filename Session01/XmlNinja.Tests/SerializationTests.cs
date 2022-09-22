using FluentAssertions;
using Xunit;

namespace XmlNinja.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void serializes_empty_tag_for_empty_object()
        {
            var customer = new Customer();
            var expected = "<Customer></Customer>";

            var serialized = NinjaSerializer.Serialize(customer);

            serialized.Should().Be(expected);
        }

        [Fact]
        public void serializes_empty_string_for_null_values()
        {
            var serialized = NinjaSerializer.Serialize(null);

            serialized.Should().BeEmpty();
        }

        [Fact]
        public void serializes_flat_object()
        {
            var person = new Person("John","Doe");
            var expected = "<Person>" +
                               "<Firstname>John</Firstname>" +
                               "<Lastname>Doe</Lastname>" +
                           "</Person>";

            var serialized = NinjaSerializer.Serialize(person);

            serialized.Should().Be(expected);
        }

        private class Customer { }
        private class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public Person(string firstname, string lastname)
            {
                Firstname = firstname;
                Lastname = lastname;
            }
        }
    }
}
