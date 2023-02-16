using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Flasker
{
    public class Bottle
    {
        public int Capacity { get; set; }
        public int Content { get; set; }

        public Bottle(int capacity)
        {
            Capacity = capacity;
        }

        public void FillToTopFromTap()
        {
            this.Content = this.Capacity;
        }

        // fyll bottle1 med bottle2
        public void FillToTop(Bottle otherBottle)
        {
           this.Content += otherBottle.Content;

           if (otherBottle.Content > this.Capacity)
            {
                otherBottle.Content = otherBottle.Content - this.Capacity;
            }
        }

        public void Fill(int otherBottleContent) // mottar en int-verdi fra .Empty()-metoden.
        {
            if (otherBottleContent > this.Capacity)
            {
                this.Content = this.Capacity;

            }
            this.Content += otherBottleContent;
        }

        public int Empty()
        {
            // bottle1.Fill(bottle2.Empty()); // Tømme flaske 2 i flaske 1

            var oldContent = this.Content; // Lagre verdien før vi kaster. 
            this.Content -= Content;
            return oldContent;
        }



    }
}
