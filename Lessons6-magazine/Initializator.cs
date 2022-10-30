using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons6_magazine
{
    internal class Initializator
    {
        internal Inventorycs Initialize()
        {
            Inventorycs inventory = new Inventorycs();
            inventory.products = new List<Product>();
            Food pizza = new Food(12, "Pizza", 19, 23.5m);
            inventory.AddProduct(pizza);
            return inventory;

        }
    }

   
    
    
}
