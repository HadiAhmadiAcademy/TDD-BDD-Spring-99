using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UISample
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);

            driver.Navigate().GoToUrl("http://parseek.ir/");
            driver.FindElement(By.Name("q")).SendKeys("test driven development");
            driver.FindElement(By.Name("b")).Click();
            driver.Close();
        }
    }
}
