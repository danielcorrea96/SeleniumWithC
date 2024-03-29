using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.utils;
using WebPurchasesBDD.Utils;

namespace TestProjectLearn.userinterfaces
{
    internal class BuyProductsPage
    {
        public BuyProductsPage() { }

        public static By OPTION_PRODUCTS = By.XPath("//a[@href='/products']");
        public static By OPTION_CART = By.XPath("//a[@href='/view_cart']");

        public static By ALERT = By.XPath("//div[@id='dismiss-button']");
        public static By ALL_PRODUCTS = By.XPath("//h2[contains(text(),'All Products')]");

        public static By category(string category) {
            return By.XPath(FindElementWithText.theXPath("//div[@id='accordian']//a[contains(@href,'{0}')]").withText(category));
        }

        public static By subCategory(string subCategory)
        {
            return By.XPath(FindElementWithText.theXPath("//div[contains(@class,'panel-collapse in')]//a[contains(text(),'{0}')]").withText(subCategory));
        }

        public static By brand(string brand)
        {
            return By.XPath(FindElementWithText.theXPath("//div[@class='brands_products']//a[contains(@href,'{0}')]").withText(brand));
        }



    }
}
