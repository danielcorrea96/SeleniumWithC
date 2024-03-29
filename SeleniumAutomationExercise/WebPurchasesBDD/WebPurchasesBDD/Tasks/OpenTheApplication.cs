using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProjectLearn.utils;

namespace TestProjectLearn.tasks
{
    internal class OpenTheApplication
    {
        private String url; 

        public OpenTheApplication(String url) {
            this.url = url;
            performAs();
        }

        public void performAs()
        {
            WebDriverManager.instanceDriver().Navigate().GoToUrl(url);
        }

        public static OpenTheApplication withThe(String url) { 
            return new OpenTheApplication(url); 
        }

    }
}
