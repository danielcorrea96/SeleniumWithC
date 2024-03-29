using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestProjectLearn.interactions;
using TestProjectLearn.utils;
using WebPurchasesBDD.UserInterfaces;

namespace WebPurchasesBDD.Tasks
{
    internal class DeleteAllProduct
    {
        public DeleteAllProduct() {
            performAs();
        }

        private void performAs() {
            foreach (IWebElement item in WebDriverManager.instanceDriver().FindElements(CartPage.LIST_PRODUCTS_FOR_DELETE))
            {
                WebDriverWait wait = new WebDriverWait(WebDriverManager.instanceDriver(), TimeSpan.FromSeconds(3));
                wait.Until(ExpectedConditions.ElementToBeClickable(item)).Click();
            }
        }
        
        public static DeleteAllProduct intoOfCart() { return new DeleteAllProduct(); }
    }
}
