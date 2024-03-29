using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.interactions;

namespace WebPurchasesBDD.Tasks
{
    internal class FilterTheProduct
    {
        private static By? category;
        private By? subCategory;
        private By? brand;

        public FilterTheProduct(By theCategory) {
            category = theCategory;
        }


        public void performAs() {
            try
            {
                Click.onTheElement(category);
                Click.onTheElement(subCategory);
                Click.onTheElement(brand);
            }
            catch (Exception)
            {
                Console.WriteLine("The item no exist in the page.");
                throw;
            }
          
        }

        public static FilterTheProduct byTheCategory(By theCategory)
        {
            category = theCategory;
            return new FilterTheProduct(theCategory);
        }

        public FilterTheProduct andTheSubCategory(By theSubCategory)
        {
            subCategory = theSubCategory;
            return this;
        }
        public FilterTheProduct andTheBrand(By theBrand)
        {
            brand = theBrand;
            return this;
        }



    }
}
