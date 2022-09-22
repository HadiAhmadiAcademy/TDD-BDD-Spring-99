namespace UOM.Domain.Model.UnitOfMeasures
{
    public class ScaledUnitOfMeasure
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public decimal ConversionRate { get; private set; }
        public long BaseUnitOfMeasureId { get; private set; }
        public ScaledUnitOfMeasure(int id, string name, string symbol, decimal conversionRate, BaseUnitOfMeasure baseUom)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            ConversionRate = conversionRate;
            BaseUnitOfMeasureId = baseUom.Id;
        }

        public decimal ConvertToBase(decimal amount)
        {
            return amount * ConversionRate;
        }

        public decimal ConvertTo(ScaledUnitOfMeasure targetUom, int amount)
        {
            var valueInBase = ConvertToBase(amount);    //2G
            return valueInBase / targetUom.ConversionRate;  //1000
        }
    }
}