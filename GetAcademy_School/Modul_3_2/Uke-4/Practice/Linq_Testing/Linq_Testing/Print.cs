using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Testing
{
    public class Print
    {
        public void PrintResult(Country[] resultArr)
        {
            foreach (var country in resultArr)
            {
                Console.WriteLine(country.Name);
            }
        }
    }
}

/*
 Det var jo ikke så mye der. Litt usikker på hva du er ute etter.
Du kan jo prøve å lage en unit test - det skal funke det.
Visning av data i Print - når du ikke har objektvariabler, så kan du like så godt ha en static metode.
sånn som du har gjort i Search
sånn sett kan du ha begge metodene i samme klasse.
Om du vil unngå static, så kan du se på repoet fra timen i dag og gjøre det som jeg gjorde der (CountryApp)
 
 */