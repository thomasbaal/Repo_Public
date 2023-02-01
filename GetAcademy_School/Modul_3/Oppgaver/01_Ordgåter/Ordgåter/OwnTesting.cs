using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ordgåter
{
    internal class OwnTesting
    {

        public static void MySubstring()
        {
            var testText = "hvaSkjerHerDa";

            WriteLine(testText.Length); // 13
            WriteLine(testText.Length - 4); // 9
            WriteLine(testText.Substring(9)); // erda
        }
    }
}
