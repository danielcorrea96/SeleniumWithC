using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPurchasesBDD.Interactions
{
    internal class Scroll
    {

        public Scroll() { }


        public static void untilElement(IWebDriver driver, IWebElement elemento)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", elemento);
        }
    }
}
