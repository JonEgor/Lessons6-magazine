using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        
    }
}
