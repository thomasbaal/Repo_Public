using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Testing
{
    public class Country
    {
        public int Rank { get; }
        public string Name { get; }
        public int Population { get; }
        public int Area { get; }

        public Country(int rank, string name, int population, int area)
        {
            Area = area;
            Population = population;
            Name = name;
            Rank = rank;
        }
    }
}
