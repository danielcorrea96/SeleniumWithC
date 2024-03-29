using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TestProjectLearn.interactions;
using TestProjectLearn.userinterfaces;
using TestProjectLearn.utils;
using static System.Net.Mime.MediaTypeNames;

namespace WebPurchasesBDD.Interactions
{
    internal class CloseTheAlert
    {
        private By element;

        public CloseTheAlert(By element) {
            this.element = element;
        }  

        public void performAs() {
            if(StateElement.evaluateIfPresent(element))
            {
                string name = WebDriverManager.instanceDriver().FindElement(By.XPath("//iframe[contains(@style,'visible')]"))
                                    .GetAttribute("name");

                WebDriverManager.instanceDriver().SwitchTo().Frame(name);

                evaluateIfAlertIsTheSameIframe();
            }
            
            WebDriverManager.instanceDriver().SwitchTo().DefaultContent();
         
        }

        private void evaluateIfAlertIsTheSameIframe() {
            if (StateElement.evaluateIfClickable(BuyProductsPage.ALERT))
            {
                Console.WriteLine("Sin pasar a otro");
                WebDriverManager.instanceDriver().FindElement(BuyProductsPage.ALERT).Click();
            }
            else
            {
                Console.WriteLine("Pasando a otro");
                WebDriverManager.instanceDriver().SwitchTo().Frame("ad_iframe");
                WebDriverManager.instanceDriver().FindElement(BuyProductsPage.ALERT).Click();
            }
        }

        public static CloseTheAlert ifPresent(By element) { return new CloseTheAlert(element); }
    }
}
