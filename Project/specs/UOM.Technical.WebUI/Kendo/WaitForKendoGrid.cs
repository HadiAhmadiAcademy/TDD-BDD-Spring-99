using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using UOM.Technical.WebUI.Framework.Interactions;

namespace UOM.Technical.WebUI.Kendo
{
    public class WaitForKendoGrid : WebInteraction
    {
        public override void Execute(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("k-loading-image")));
        }
    }
}