using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Lessons6_magazine
{
    internal class Initializator
    {
        internal Inventorycs Initialize()
        {
            Inventorycs inventory = new Inventorycs();
            inventory.products = new List<Product>();
            Food pizza = new Food(12, "Pizza", 19, 23.5m);
            Food bigmak = new Food(12, "Big Mak", 20, 5.50m);
            Chemical washingPowder = new Chemical("No", "Washing powder", 13, 20.3m);
            Machinery washingMachine = new Machinery("Yes", "Washing machine", 3, 100.2m);
            inventory.AddProduct(pizza);
            inventory.AddProduct(bigmak);
            inventory.AddProduct(washingPowder);
            inventory.AddProduct(washingMachine);
            return inventory;


        }
    }

   
    
    
}
