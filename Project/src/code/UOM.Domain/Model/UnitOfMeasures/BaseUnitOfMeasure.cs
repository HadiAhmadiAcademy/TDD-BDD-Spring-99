using UOM.Domain.Model.Dimensions;

namespace UOM.Domain.Model.UnitOfMeasures
{
    public class BaseUnitOfMeasure
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public long Dimension { get; private set; }
        public BaseUnitOfMeasure(long id, string name, string symbol, Dimension dimension)
        {
            this.Dimension = dimension.Id;
            this.Name = name;
            this.Symbol = symbol;
            Id = id;
        }
    }
}