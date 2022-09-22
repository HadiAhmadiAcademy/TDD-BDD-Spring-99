using Suzianna.Core.Screenplay;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;
using UOM.Technical.Rest.Tasks;
using UOM.Technical.WebUI.Tasks;

namespace UOM.Specs.Screenplay.Tasks
{
    public static class Define
    {
        public static ITask Dimension(MeasurementDimension dimension)
        {
            return Factory.CreateTask<DefineDimension>(dimension);
        }
    }
}