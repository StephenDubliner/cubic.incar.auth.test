using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace cubic.incar.auth.test
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException(
                        "The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }

            private set { driver = value; }
        }

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (Driver == null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox", Driver);
                    }

                    break;

                case "IE":
                    if (Driver == null)
                    {
                        driver = new InternetExplorerDriver(ConfigurationManager.AppSettings["IEDriverPath"]);
                        Drivers.Add("IE", Driver);
                    }

                    break;

                case "Chrome":
                    if (Driver == null)
                    {
                        driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriverPath"]);
                        Drivers.Add("Chrome", Driver);
                    }

                    break;

                default:
                    throw new NotImplementedException("Unsupported browser:" + browserName);
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }
}