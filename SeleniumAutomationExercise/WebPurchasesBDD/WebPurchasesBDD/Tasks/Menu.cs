using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.interactions;

namespace WebPurchasesBDD.Tasks
{
    internal class Menu
    {
       private By option;
       public Menu(By option)
        {
            this.option = option;
            performAs();
        }

        private void performAs()
        {
            Click.onTheElement(option);
        }

        public static Menu withTheOption(By option)
        {
            return new Menu(option);
        }

    }
}
