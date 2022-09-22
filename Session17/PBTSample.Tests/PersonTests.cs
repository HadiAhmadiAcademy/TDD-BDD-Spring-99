using FluentAssertions;
using FsCheck;
using FsCheck.Xunit;

namespace PBTSample.Tests
{
    public class PersonTests
    {
        [Property]
        public Property testing_shrinking_feature()
        {
            return Prop.ForAll(StringGenerator.Generate(), firstname =>
            {
                var person = new Person(firstname);
                person.Firstname.Should().Be(firstname);
            });
        }
    }
}