using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.utils;

namespace WebPurchasesBDD.Interactions
{
    internal class StateElement
    {

        public StateElement() { }

        public static Boolean evaluateIfPresent(By element)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverManager.instanceDriver(), TimeSpan.FromSeconds(3));
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(element));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public static Boolean evaluateIfClickable(By element)
        {
            WebDriverWait wait = new WebDriverWait(WebDriverManager.instanceDriver(), TimeSpan.FromSeconds(3));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }


    }
}
