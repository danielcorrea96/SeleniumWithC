using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPurchasesBDD.Utils;

namespace WebPurchasesBDD.UserInterfaces
{
    internal class CartPage
    {
        public CartPage() { }

        public static By LIST_COUNT_ADDED_PRODUCTS = By.XPath("//section[@id='cart_items']//tr[contains(@id,'product')]//td[@class='cart_quantity']//button");
        
        
        public static By LIST_PRODUCTS_FOR_DELETE = By.XPath("//td[@class='cart_delete']//a");
        
        
        public static By CART_IS_EMPTY = By.XPath("//b[contains(text(),'Cart is empty!')]");

        public static By deleteProduct(string product)
        {
            return By.XPath(FindElementWithText.theXPath("(//section[@id='cart_items']//a[contains(text(),'{0}')]//following::td[@class='cart_delete']//a)[1]")
                .withText(product));
        }

        
    }
}
