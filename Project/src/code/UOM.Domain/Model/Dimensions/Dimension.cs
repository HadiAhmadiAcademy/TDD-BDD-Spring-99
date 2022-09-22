namespace UOM.Domain.Model.Dimensions
{
    public class Dimension
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }

        public Dimension(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}