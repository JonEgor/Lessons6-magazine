using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons6_magazine
{
    
    
        internal class Machinery : Product
        {
            public string _forHome { get; private set; }
            public Machinery(string forHome, string name, int quantity, decimal price) : base(name, quantity, price)
            {

                _forHome = forHome;
            }
        }

}