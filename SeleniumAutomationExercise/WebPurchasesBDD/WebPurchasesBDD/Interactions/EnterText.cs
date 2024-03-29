using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.utils;

namespace TestProjectLearn.interactions
{
    internal class EnterText
    {
        private static String text;

        public EnterText() { }

        public static EnterText theText(String theText) {
            text = theText;
            return new EnterText();
        }

        public void onTheElement(By element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(WebDriverManager.instanceDriver(), TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementToBeClickable(element)).SendKeys(text);
            }
            catch (Exception)
            {
                Console.WriteLine("The element not clickable.");
                throw;
            }
        }
    }
}
