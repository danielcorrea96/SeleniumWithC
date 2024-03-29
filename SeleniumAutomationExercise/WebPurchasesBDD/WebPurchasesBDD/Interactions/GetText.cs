using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TestProjectLearn.utils;

namespace DomainWebsiteBDD.Interactions
{
    internal class GetText
    {
        public GetText() { }

        public static string onTheElement(By element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(WebDriverManager.instanceDriver(), TimeSpan.FromSeconds(10));
                return wait.Until(ExpectedConditions.ElementToBeClickable(element)).Text;
            }
            catch (Exception)
            {
                Console.WriteLine("The element not clickable.");
                throw;
            }
        }
    }


}
