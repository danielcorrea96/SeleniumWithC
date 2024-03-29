using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPurchasesBDD.Utils;

namespace TestProjectLearn.userinterfaces
{
    internal class AddToCartPage
    {
       
     public static By theInformationOf(string product)
        {
            return By.XPath(FindElementWithText.theXPath(" (//div[@class='features_items']//div[contains(@class,'productinfo')]//p[contains(text(),'{0}')]//following::a)[1]")
                .withText(product));
        }


        public static By getThePriceOfProduct(string product)
        {
            return By.XPath(FindElementWithText.theXPath("//div[@class='features_items']//div[contains(@class,'productinfo')]//p[contains(text(),'{0}')]//ancestor::div[contains(@class,'productinfo')]//h2")
                .withText(product));
        }

        public static By ADDED_PRODUCT = By.XPath("//h4[contains(text(),'Added!')]");

        public static By CONTINUE_SHOPPING = By.XPath("//button[contains(text(),'Continue Shopping')]");



    }
}
