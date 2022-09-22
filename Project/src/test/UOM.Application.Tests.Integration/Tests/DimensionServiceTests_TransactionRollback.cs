using FluentAssertions;
using Microsoft.Data.SqlClient;
using UOM.Application.Contracts;
using UOM.Domain.Model.Dimensions;
using UOM.Persistence.EF;
using UOM.Persistence.EF.Repositories;
using Xunit;

namespace UOM.Application.Tests.Integration.Tests
{
    public class DimensionServiceTests_TransactionRollback : PersistTest
    {
        [Fact]
        public void saves_a_dimension_into_database()
        {
            var repository = new DimensionRepository(UomContext);
            var service = new DimensionService(repository);
            var dto = new DefineDimensionDto(){ Name = "Temperature", Symbol = "T" };
            var expected = new Dimension("Temperature", "T");

            var id = service.DefineDimension(dto);
            UomContext.DetachAllEntities();

            var actualDimension = repository.GetById(id);
            actualDimension.Should().BeEquivalentTo(expected, a=> a.Excluding(z=>z.Id));
        }
    }
}
