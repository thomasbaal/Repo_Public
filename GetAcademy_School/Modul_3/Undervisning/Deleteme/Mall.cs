using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Deleteme
{
    internal class Mall
    {
        public string MallName { get; set; }
        public List<Store> Stores { get; set; }
        public List<Toilet> Toilets { get; set; }
        public List<Customer> Customers { get; set; }
        public Info Info { get; set; }
        public Mall(string mallName)
        {
            MallName = mallName;
            Stores = new List<Store>();
            
        }
        // this should be sharable between all added stores !?
        public void AddStoreToList(Store store)
        {
            Stores.Add(store);
        }

        public void DisplayInfo()
        {
            foreach (var store in Stores)
            {
                WriteLine($"Name of store: {store.StoreName}");
            }
        }

    }
}
 