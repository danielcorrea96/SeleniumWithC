using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLearn.utils
{
    internal class WebDriverManager
    {
        private static IWebDriver driver;

        public WebDriverManager()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("incognito");
            options.AddArgument("disable-popup-blocking");
            options.AddArgument("disable-notifications");

            driver = new ChromeDriver(options);

        }

        public static IWebDriver instanceDriver() {
            return driver;
        }   
    }
}
