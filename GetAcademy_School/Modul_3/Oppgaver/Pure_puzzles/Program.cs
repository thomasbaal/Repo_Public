using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              ########
               ######
                ####
                 ##
            */

            Console.WriteLine("Drawing a pot -------------------------");
            Exercise_2_1();
            Console.ReadLine();

        }

        private static void Exercise_2_1()
        {
            for (int i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * 1);
            }
        }

        private static void Space(int rowCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                MySymbol();
            }
        }

        //private static void Space(int rowCount)
        //{
        //    Console.WriteLine(" ");
        //}

        private static void MySymbol()
        {
            Console.Write("!");
        }

        private static void Hash(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Hash();
            }
        }

        private static void Hash()
        {
            Console.WriteLine("#");
        }

    }
}