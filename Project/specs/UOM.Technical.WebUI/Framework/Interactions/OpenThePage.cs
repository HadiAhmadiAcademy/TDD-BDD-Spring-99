using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;

namespace UOM.Technical.WebUI.Framework.Interactions
{
    public class OpenThePage : WebInteraction
    {
        private readonly string _url;
        public OpenThePage(string url)
        {
            _url = url;
        }
        public override void Execute(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(_url);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("addDimensionBtn")));
        }
    }
}