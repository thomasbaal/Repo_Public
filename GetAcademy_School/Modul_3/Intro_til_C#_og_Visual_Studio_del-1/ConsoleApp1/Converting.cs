using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndervisningIntroCS
{
    internal class Converting
    {
        static void Something()
        {
            // to string
            // anta variabel x - uansett datatype (av våre utvalgte)
            var x = true;
            
            
            string s = "" + x;
            double d = 99.123;
            string s2 = d.ToString("F");
            Console.WriteLine(s2);
            Console.ReadLine();
        }

    }
}
