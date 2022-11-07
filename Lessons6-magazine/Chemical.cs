using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons6_magazine
{
    internal class Chemical: Product 
    {
       
     
        public string _Harmfulincontactwithskin { get; private set; }
        public string Name { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        public Chemical(string harmfulincontactwithskin, string name, int quantity, decimal price) : base(name, quantity, price)
        {
            _Harmfulincontactwithskin = harmfulincontactwithskin;
        }
    }
}