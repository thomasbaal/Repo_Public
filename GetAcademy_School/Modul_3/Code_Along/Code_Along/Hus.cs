using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Along
{
    internal class Hus
    {
        public int Nummer;
        public bool Trapp;
        public int Etasjer;
        public string Farge;
        public Rom Rom;
        public Kodelås Kodelås;

        public Hus(int nummer, bool trapp, int etasjer, string farge)
        {
            Nummer= nummer;
            Trapp= trapp;
            Etasjer= etasjer;
            Farge= farge;

            Rom = new Rom(5, 10);
            Kodelås = new Kodelås(1234, 4);


        }

    }
}
