using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPurchasesBDD.Interactions;
using WebPurchasesBDD.UserInterfaces;

namespace WebPurchasesBDD.Questions
{
    internal class ValidateIfTheCart
    {
        private By element;
        public ValidateIfTheCart(By element) {
         this.element = element;
        }

        public void validateAs() {
            Boolean isEmpty = StateElement.evaluateIfPresent(element);
            Assert.IsTrue(isEmpty);
        }

        public static ValidateIfTheCart isEmpty(By element) {
            return new ValidateIfTheCart(element);  
        }
    }
}
