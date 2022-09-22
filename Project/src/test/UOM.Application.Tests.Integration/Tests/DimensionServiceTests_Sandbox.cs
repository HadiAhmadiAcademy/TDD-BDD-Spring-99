using FluentAssertions;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;
using UOM.Persistence.EF.Repositories;
using Xunit;

namespace UOM.Application.Tests.Integration.Tests
{
    public class DimensionServiceTests_Sandbox : SandboxPersistTest
    {
        [Fact]
        public void saves_a_dimension_into_database()
        {
            var repository = new DimensionRepository(DbContext);
            var service = new DimensionService(repository);
            var dto = new DefineDimensionDto()
            {
                Name = "Mass",
                Symbol = "m"
            };
            var expected = new Dimension("Mass", "m");

            var id = service.DefineDimension(dto);

            this.DbContext.DetachAllEntities();
            var actual = repository.GetById(id);
            actual.Should().BeEquivalentTo(expected, a => a.Excluding(z => z.Id));
        }
    }
}
