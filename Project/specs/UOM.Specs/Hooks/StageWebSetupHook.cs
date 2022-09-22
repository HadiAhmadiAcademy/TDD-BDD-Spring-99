using System.Collections.Generic;
using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using TechTalk.SpecFlow;
using UOM.Specs.Configuration;
using UOM.Specs.Constants;
using UOM.Technical.WebUI.Framework;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageWebSetupHook
    {
        private readonly IObjectContainer _container;
        private BrowseTheWeb browseTheWeb;
        public StageWebSetupHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("UI-Level")]
        public void SetupStage()
        {
            var x = Config.Current;

            browseTheWeb = new BrowseTheWeb();
            var cast = Cast.WhereEveryoneCan(new List<IAbility> { browseTheWeb });
            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }

        [AfterScenario("UI-Level")]
        public void DisposeAbility()
        {
            browseTheWeb.Dispose();
        }
    }
}