// Using viser til "pather" hvor visual studio skal lete etter instillinger o.s.v.
// alle disse er et eget namespace.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
Pensum i dag:
    C¤ er et sterkt type programmeringsspråk.
    Debugging.
    Grunnskjelletet i en class.
    Variabler, tilording og datatyper.
        bool - boolean (true/false)
        int - heltall
        float/double - desimaltall.
        string - tekst.
    Valgsetninger.
    Løkker - for og while som i Javascript - foreach (for tabeller)
    Tabeller.
    Metoder. (funksjoner)
    Input og Output.
 
 */



// Path for denne namespace'n (UndervisningIntroCsharp) ville da vært: using UndervisningIntroCsharp
namespace UndervisningIntroCS
{


    internal class Program
    {
        // Felt - tilsvarer Javascript (nesten) Globale variabler.

        // Metoder tilsvarer javscript sine funksjoner.

        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////
            // Deklaraere en variabel av hver av de nevnte datatypene.
            bool b;
            int i;
            float f;
            double d;
            string s;

            // Tilordning
            b = true;
            i = 5;
            f = 3.2f;
            d = 1.2;
            s = "some_text";

            // kan også deklarere og tilordne samtidig.
            bool b2 = false;
            int i2 = 3;
            float f2 = 1.3f;
            double d2 = 4.2;
            string s2 = "12345";

            var b3 = false;
            var i3 = 9;
            var f3 = 5.5f;
            var d3 = 9.9;
            var s3 = "another text";

            /////////////////////////////////////////////////////////
            // to string
            // anta variabel x - uansett datatype (av våre utvalgte)
            var x = true;


            string s5 = "" + x; 
            Console.WriteLine(s5); // True
            double d5 = 99.123;
            string s6 = d.ToString();
            Console.WriteLine(s6); // 1.2
            Console.ReadLine();
            //////////////////////////////////////////////////////////



            //////////////////////////////////////////////////////////
            // to int
            int i10 = Convert.ToInt32(f2);
            Console.WriteLine($"Converting from -float-{f2} to int. Result =  {i10}");
            Console.ReadLine();

            // to single
            // about ToSingle: Converts a specified value to a single-precision floating-point number.
            float f10 = Convert.ToSingle(f);
            Console.WriteLine($"Converting from -float-{f} to single. Result =  {f10}");
            Console.ReadLine();

            float f11 = Convert.ToSingle(d);
            Console.WriteLine($"Converting from -double-{d} to single. Result =  {f11}");
            Console.ReadLine();

            float f12 = Convert.ToSingle(b);
            Console.WriteLine($"Converting from -bool-{b} to single. Result =  {f12}"); // 1
            Console.ReadLine();


            float f13 = Convert.ToSingle(b3);
            Console.WriteLine($"Converting from -bool-{b3} to single. Result =  {f13}"); // 0
            Console.ReadLine();

            //to double
            double d10 = Convert.ToDouble(s2);
            Console.WriteLine($"Converting from -string-{s} to double. Result =  {d10}"); // 0
            Console.ReadLine();



            /////////////////////////////////////////////////////////////////
            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Halooo! Ingen parametre.");
            //}
            //else
            //{
            //    Console.WriteLine("Antall Parametre: " + args.Length);
            //}
            //// Void betyr tom, dvss at den ikke skal returnere noe verdi.
            //// fremfor void kan definere datatypen som den skal returnere, da må void tas bort.
            //// string[] betyr at den tar inn et array med tekst parametere.

            //foreach(var arg in args)
            //{
            //    Console.WriteLine("Parameter: " + arg);
            //}
            /////////////////////////////////////////////////////////////////

        }
    }
}
