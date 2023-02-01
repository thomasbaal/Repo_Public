using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleteme
{
    internal class Customer
    {
        public List<Product> CustomerProducts { get; set; }

        public Customer()
        {
            CustomerProducts = new List<Product>();
        }

    }
}
