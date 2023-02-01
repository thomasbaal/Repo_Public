using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Testing
{
    public class ListHandler
    {

        public static Country[] StartsWith(Country[] countryArr, string userCommand)
        {
            var listStarsWith = countryArr.Where(c => c.Name.StartsWith(userCommand));
            return listStarsWith.ToArray();
        }

        public static Country[] Contains(Country[] countryArr,string userCommand)
        {
            var listContains = countryArr.Where(c => c.Name.Contains(userCommand));
            return listContains.ToArray();
        }

        public static Country[] PopulationAbove(Country[] listOfCountries, int userCommand)
        {
            var listPopulationAbove = listOfCountries.Where(c => c.Population > userCommand);
            return listPopulationAbove.ToArray();
        }

        public static Country[] PopulationBelow(Country[] listOfCountries, int numberToSearch)
        {
            var listPopulationBelow = listOfCountries.Where(c => c.Population < numberToSearch);
            return listPopulationBelow.ToArray();
        }

        public static Country[] CreateAscendingList(Country[] listOfCountries)
        {
            var listCountyNamesAscending = listOfCountries.OrderBy(c => c.Name);    
            return listCountyNamesAscending.ToArray();
        }

        public static Country[] CreateDescendingList(Country[] listOfCountries)
        {
            var listCountryNamesDescending = listOfCountries.OrderByDescending(c =>c.Name);
            return listCountryNamesDescending.ToArray();
        }

        


    }
}
