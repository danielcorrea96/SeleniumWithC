using AventStack.ExtentReports.Model;
using DomainWebsiteBDD.Questions;
using System;
using TechTalk.SpecFlow;
using TestProjectLearn.interactions;
using TestProjectLearn.tasks;
using TestProjectLearn.userinterfaces;
using WebPurchasesBDD.Interactions;
using WebPurchasesBDD.Models;
using WebPurchasesBDD.Questions;
using WebPurchasesBDD.Tasks;
using WebPurchasesBDD.UserInterfaces;
using WebPurchasesBDD.Utils;

namespace WebPurchasesBDD.StepDefinitions
{
    [Binding]
    public class BuyProductsStepDefinitions
    {
        private List<Product> products;
        [Given(@"the user tries to open the application")]
        public void GivenTheUserTriesToOpenTheApplication()
        {
            OpenTheApplication.withThe("https://automationexercise.com/");
            Menu.withTheOption(BuyProductsPage.OPTION_PRODUCTS);
        }
        
        [When(@"to purchase products")]
        public void WhenToPurchaseTenProducts(Table table)
        {
            products = ConvertDataTable.convertListOfProducts(table);
            foreach (var product in products) {
                FilterTheProduct.byTheCategory(BuyProductsPage.category(product.category))
                    .andTheSubCategory(BuyProductsPage.subCategory(product.subcategory))
                    .andTheBrand(BuyProductsPage.brand(product.brand)).performAs();

                AddToProducts.withThe(AddToCartPage.theInformationOf(product.nameOfProduct));
            }
        }

        [Then(@"the user should see that (.*) have been added to the cart with their total price")]
        public void ThenTheUserShouldSeeThatTheyHaveBeenAddedToTheCartWithTheirTotalPrice(int count)
        {
            Menu.withTheOption(BuyProductsPage.OPTION_CART);
            ValidateCountProduct.inThePage(count.ToString());
            DeleteAllProduct.intoOfCart();

        }

        [Then(@"then he should delete from the added products to validate the empty cart")]
        public void ThenThenHeShouldDeleteFromTheAddedProductsToValidateTheEmptyCart()
        {
            ValidateIfTheCart.isEmpty(CartPage.CART_IS_EMPTY);
        }
    }
}
