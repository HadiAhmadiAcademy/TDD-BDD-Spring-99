using OpenQA.Selenium;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;
using UOM.Technical.WebUI.Framework.Interactions;
using UOM.Technical.WebUI.Kendo;
using UOM.Technical.WebUI.Questions;

namespace UOM.Technical.WebUI.Tasks
{
    public class DefineDimensionWeb : DefineDimension
    {
        public DefineDimensionWeb(MeasurementDimension dimension) : base(dimension)
        {
        }
        protected override long Execute<T>(T actor)
        {
            actor.AttemptsTo(
                new OpenThePage("http://localhost:4200/dimension-list"),
                new Click(By.Id("addDimensionBtn")),
                new FillInput(By.Id("name"), Dimension.Name),
                new FillInput(By.Id("symbol"), Dimension.Symbol),
                new Click(By.Id("saveButton")),
                new WaitForKendoGrid()
            );
            var dataInGrid = actor.AsksFor(new DataInKendoGrid<MeasurementDimension>());
            //........

            return 0;
        }
    }
}