using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectLearn.utils;
using static System.Net.Mime.MediaTypeNames;

namespace WebPurchasesBDD.Utils
{
    internal class FindElementWithText
    {
        private string xpath;

        public FindElementWithText(string xpath) {
            this.xpath = xpath;
        }

        public static FindElementWithText theXPath(string xpath)
        {
            return new FindElementWithText(xpath);
        }

        public string withText(string text)
        {
            return string.Format(xpath, text);
        }
    }
}
