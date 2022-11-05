using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace GetTitleWithSelenium
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            IWebDriver WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("https://google.com");
            WebDriver.FindElement(By.XPath("//input[@name=\"q\"]")).SendKeys("Hello World");
            WebDriver.FindElement(By.XPath("//input[@name=\"btnK\"]")).SendKeys(Keys.Enter);

            string GetTitle = WebDriver.Title;
            Console.ForegroundColor = ConsoleColor.Red;
            log.Info($"{GetTitle}");
            Console.ResetColor();



        }
    }
}
