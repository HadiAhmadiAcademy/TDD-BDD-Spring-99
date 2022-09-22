using System;
using System.Collections.Generic;
using System.IO;
using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using TechTalk.SpecFlow;

namespace Specs.Hooks
{
    [Binding]
    public class SandboxHook
    {
        private Guid SandboxId;
        private readonly IObjectContainer _container;
        public SandboxHook(IObjectContainer container)
        {
            _container = container;
        }
        
        [BeforeScenario("Sandbox")]
        public void SetupSandboxDatabase()
        {

            SandboxId = Guid.NewGuid();
            // create database with sandboxId
            // run migration on created database
            var sandBoxInterceptor = new SandboxInterceptor(SandboxId);

            var cast = Cast.WhereEveryoneCan(new List<IAbility>()
            {
                CallAnApi.At("http://localhost:5000").WhichRequestsInterceptedBy(sandBoxInterceptor)
            });
            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }

        [AfterScenario("Sandbox")]
        public void TeardownSandboxDatabase()
        {
            // drop sandbox database
        }
    }
}