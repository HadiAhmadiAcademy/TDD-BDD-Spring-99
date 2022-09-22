using System;
using System.Threading;
using OpenQA.Selenium;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;

namespace UOM.Technical.WebUI.Framework.Interactions
{
    public abstract class WebInteraction : IInteraction
    {
        public void PerformAs<T>(T actor) where T : Actor
        {
            var ability = actor.FindAbility<BrowseTheWeb>();
            Execute(ability.Driver);
            Thread.Sleep(1000);  //TODO: remove this explicit wait and use selenium wait mechanism
        }
        public abstract void Execute(IWebDriver driver);
    }
}