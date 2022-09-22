using OpenQA.Selenium;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;

namespace UOM.Technical.WebUI.Framework.Interactions
{
    public class Click : WebInteraction
    {
        private readonly By _by;
        public Click(By by)
        {
            _by = by;
        }
        public override void Execute(IWebDriver driver)
        {
            driver.FindElement(_by).Click();
        }
    }
}