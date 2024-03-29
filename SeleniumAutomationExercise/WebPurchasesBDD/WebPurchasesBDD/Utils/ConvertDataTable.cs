using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPurchasesBDD.Models;

namespace WebPurchasesBDD.Utils
{
    internal class ConvertDataTable
    {
        public static List<Product> convertListOfProducts(Table table)
        {
            var list = new List<Product>();

            foreach (var row in table.Rows)
            {
                list.Add(new Product {
                    category = row["category"],
                    subcategory = row["subcategory"],
                    brand = row["brand"],
                    nameOfProduct = row["nameOfProduct"],
                });
            }
            return list;
        }
    }
}
