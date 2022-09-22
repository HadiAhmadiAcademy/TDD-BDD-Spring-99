using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace WaitSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:4200/dimension-list");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("addDimensionBtn")));

            var watch = new Stopwatch();
            watch.Start();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("k-loading-image")));
            driver.Close();
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            Console.ReadLine();
        }
    }
}
