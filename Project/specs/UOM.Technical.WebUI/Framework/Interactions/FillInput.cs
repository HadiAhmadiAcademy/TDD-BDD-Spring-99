using OpenQA.Selenium;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;

namespace UOM.Technical.WebUI.Framework.Interactions
{
    public class FillInput : WebInteraction
    {
        private readonly By _by;
        private readonly string _text;
        public FillInput(By by, string text)
        {
            _by = by;
            _text = text;
        }

        public override void Execute(IWebDriver driver)
        {
            driver.FindElement(this._by).SendKeys(_text);
        }
    }
}