using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons6_magazine
{
    internal class Food : Product
    {
        public int _bestBeforeDate { get; private set; }
        public Food(int bestBeforeDate, string name, int quantity, decimal price) : base(name, quantity, price)
        {
            _bestBeforeDate = bestBeforeDate;
        }

              
            

        
    }
}
