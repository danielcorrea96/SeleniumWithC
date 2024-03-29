using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.userinterfaces;
using TestProjectLearn.utils;
using WebPurchasesBDD.Interactions;

namespace TestProjectLearn.interactions
{
    internal class Click
    {
        private static By IFRAME_VISIBLE = By.XPath("//iframe[contains(@style,'visible')]");
        public Click() { }

        public static void onTheElement(By element) {
            CloseTheAlert.ifPresent(IFRAME_VISIBLE).performAs();
            try
            {
                IWebDriver driver = WebDriverManager.instanceDriver();

                WebDriverWait wait = new WebDriverWait(WebDriverManager.instanceDriver(), TimeSpan.FromSeconds(2));
                WebDriverManager.instanceDriver().FindElement(element);
                Scroll.untilElement(driver, driver.FindElement(element));
                wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
            }
            catch (Exception)
            {
                Console.WriteLine("The element not clickable.");
                throw;
            }
        }
    }
}
