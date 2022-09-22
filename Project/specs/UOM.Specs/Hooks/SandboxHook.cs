using System.Collections.Generic;
using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using TechTalk.SpecFlow;
using UOM.Specs.Constants;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageSandboxHook
    {
        private readonly IObjectContainer _container;
        public StageSandboxHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("Sandbox")]
        public void SetupStage()
        {
            //Setup Database sandbox (Create database & run migration)

            //Set Database name on Interceptor to be send with all requests
        }
    }
}