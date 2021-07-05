using System;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumDynamicissueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverOptions = new ChromeOptions();

            driverOptions.AddAdditionalOption("se:recordVideo", true);
            driverOptions.AddAdditionalOption("se:timeZone", "US/Pacific");
            driverOptions.AddAdditionalOption("se:screenResolution", "1920x1080");

            var driver = new RemoteWebDriver(new Uri("http://seleniumHub:4444"), driverOptions)
            {
            };

        }
    }
}
