using UOM.Domain.Model.UnitOfMeasures;

namespace UOM.Domain.Tests.Unit.TestUtils
{
    public static class BaseUnitOfMeasureFactory
    {
        public static BaseUnitOfMeasure CreateGram()
        {
            var mass = DimensionFactory.CreateMassDimension();
            return new BaseUnitOfMeasure(1, "Gram","gr", mass);
        }
    }
}