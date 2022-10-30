using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons6_magazine
{
    internal class Inventorycs
    {
        internal List<Product> products;
        public void AddProduct(Product product)
        {
            object value = product.Add(product);
        }
         public void Print()
        {
            Console.WriteLine(products[0].name);
            Console.WriteLine(products[0].price);
            Console.WriteLine(products[0].quantity);
           
        }
    }

}
