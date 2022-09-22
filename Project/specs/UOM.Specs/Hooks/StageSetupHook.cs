using System.Collections.Generic;
using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using TechTalk.SpecFlow;
using UOM.Specs.Constants;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageApiSetupHook
    {
        private readonly IObjectContainer _container;
        public StageApiSetupHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("API-Level")]
        public void SetupStage()
        {
            var cast = Cast.WhereEveryoneCan(new List<IAbility> { CallAnApi.At(ApiConstants.BaseUrl) });
            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }
    }
}