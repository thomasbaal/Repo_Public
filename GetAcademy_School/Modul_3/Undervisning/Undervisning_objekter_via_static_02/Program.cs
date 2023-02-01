using static System.Console;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning_objekter_via_static_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var aPlace = new Place("thomas", "bøldfa", "lågensldafa", 3288);
            var bPlace = new TheOtherPlace();



       // Alternative way to create a objet from a class and set properties. 
            
            //var place = new Place();
            //place.Fname = "Thomas";
            //place.Lname = "Blæsrumosen";
            //place.Address = "Lunkedalsmoen";
            //place.postnumber = 3282;

            //var place2 = new Place();
            //place2.Fname = "Fredrik";
            //place2.Lname = "Blunkerud";
            //place2.Address = "Larviksvingen";
            //place2.postnumber = 3286;



            //Place.ShowPlace("Thomas", "Blæsrøden", "Kvelde", 3282);
            //Place.ShowPlace("Fredrik", "Mnjadaman", "Larvik", 3296);

            ReadLine();

        }


       



    }
}
