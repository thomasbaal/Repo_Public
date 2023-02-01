using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minioppgave_Nyrer
{
    internal class Kidneys_Class
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Owner { get; set; }
        public int IndexCount { get; set; } 
        
        
        //public static int count = 0;

        public Kidneys_Class(int indexCount)
        {
           IndexCount = indexCount;
        }

        public Kidneys_Class(string aType, decimal aPrice, int aAmount, string aOwner)
        {
            Type = aType;
            Price = aPrice;  
            Amount = aAmount;
            Owner = aOwner;
            //count++;
        }

        public Kidneys_Class(string aType, decimal aPrice, int aAmount, string aOwner, int indexCount)
        {
            Type = aType;
            Price = aPrice;
            Amount = aAmount;
            Owner = aOwner;
            IndexCount = indexCount;
            //count++;
        }






    }
}
