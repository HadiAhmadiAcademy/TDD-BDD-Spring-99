using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Suzianna.Core.Screenplay;

namespace UOM.Technical.WebUI.Framework
{
    public class BrowseTheWeb : IAbility, IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public BrowseTheWeb()
        {
            //TODO: remove the path of chrome from here
            string path =
                @"C:\Users\Hadi\Source\Repos\TDD-BDD-Spring99\Project\specs\UOM.Technical.WebUI\bin\Debug\netcoreapp2.0\";
            Driver = new ChromeDriver(path);    
        }
        public void Dispose()
        {
            Driver.Close();
            Driver?.Dispose();
        }
    }
}