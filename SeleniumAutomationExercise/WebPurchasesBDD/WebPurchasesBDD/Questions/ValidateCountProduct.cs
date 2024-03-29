using DomainWebsiteBDD.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.userinterfaces;
using TestProjectLearn.utils;
using WebPurchasesBDD.UserInterfaces;

namespace DomainWebsiteBDD.Questions
{
    internal class ValidateCountProduct
    {
        private string countOfElement;

        public ValidateCountProduct(string countOfElement) {
            this.countOfElement = countOfElement;
            validateAs();
        }


        private void validateAs() {
            int countElements = 0;

            foreach (IWebElement item in WebDriverManager.instanceDriver().FindElements(CartPage.LIST_COUNT_ADDED_PRODUCTS))
            {
                string countOfProduct = item.Text;
                countElements += int.Parse(countOfProduct);
            }

            if (countElements.ToString().Equals(countOfElement))
            {
                Assert.IsTrue(true);
                  
            }
            else
            {
                Assert.Fail("The number of items expected is not the same, currently there are " +
                    "" + countElements + "  items added to the cart.");
            }
        }
        public static ValidateCountProduct inThePage(string countOfElement) {
            return new ValidateCountProduct(countOfElement);
        }
    }
}
