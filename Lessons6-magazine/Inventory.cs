
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Lessons6_magazine
{
    
    internal class Inventorycs
    {
        internal List<Product> products;
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void Print()
        {
            Console.WriteLine(products[0].name);
            Console.WriteLine(products[0].price);
            Console.WriteLine(products[0].quantity);

        }
    
        internal void AddProduct(Chemical washingPowder)
        {
            throw new NotImplementedException();
        }

        internal object PrintAllProduct()
        {
            throw new NotImplementedException();
        }

        internal void SortForFoods<T>()
        {
            throw new NotImplementedException();
        }

    }

   
}

