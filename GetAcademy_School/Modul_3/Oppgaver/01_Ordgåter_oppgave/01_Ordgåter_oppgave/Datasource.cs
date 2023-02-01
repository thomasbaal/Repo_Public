using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_Ordgåter_oppgave
{
    public class Datasource
    {
        public void CreateWordList()
        {
            var filePath = "NorskOrdliste.txt";

            var line = File.ReadAllLines(filePath);
            foreach (var part in line)
            {
                var partsFromLine = part.Split('\t');


            }

        }
    }
}
