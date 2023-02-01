using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Code_Along
{
    internal class Lock
    {
        public int LockNumber = 5422;


        public Lock()
        {

        }

        public void Run()
        {
            WriteLine("Type in a number for the lock !");
            try
            {
                var userInput =  Convert.ToInt32(ReadLine());
                if (userInput == LockNumber)
                {
                    WriteLine("Woopi dude !");
                }
                else
                {
                    WriteLine("Burp, wrong !!");
                }
            }
            catch (Exception)
            {

                throw;
            }



            ReadLine();
        }

    
    }





}
