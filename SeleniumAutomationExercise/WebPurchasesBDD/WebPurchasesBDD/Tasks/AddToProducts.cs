using DomainWebsiteBDD.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.interactions;
using TestProjectLearn.userinterfaces;
using TestProjectLearn.utils;

namespace WebPurchasesBDD.Tasks
{
    internal class AddToProducts
    {
        private By product;
        private string isAddedProduct = "Added!";
        private List<string> priceAddedProducts = new List<string>();

        public AddToProducts(By product) {
            this.product = product;
            performAs();
        }  


        public void performAs() {
            Click.onTheElement(product);
            string addedProduct = GetText.onTheElement(AddToCartPage.ADDED_PRODUCT);
            Assert.AreEqual(isAddedProduct, addedProduct);
            Click.onTheElement(AddToCartPage.CONTINUE_SHOPPING);
        }




        public  static AddToProducts withThe(By product) { return new AddToProducts(product); }



    }
}
