using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons6_magazine
{
    
    internal class Product
    {
        public string name { get; private set; }
        public int quantity { get; private set; }
        public decimal price { get; private set; }

        public Product(string name, int quantity, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public class Chemical
        {
            public string Name { get; private set; }
            public int Quantity { get; private set; }
            public decimal Price { get; private set; }


        }
    }
}
    
