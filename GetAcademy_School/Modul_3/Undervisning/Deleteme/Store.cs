using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleteme
{
    internal class Store
    {
        public string StoreName { get; set; }
        public List<Product> Products { get; set; }
        public List<Customer> Customers { get; set; }

        public Store(string storeName)
        {
            StoreName = storeName;
            Products = new List<Product>();
            Customers = new List<Customer>();
           
        }

       
     


    }
}
