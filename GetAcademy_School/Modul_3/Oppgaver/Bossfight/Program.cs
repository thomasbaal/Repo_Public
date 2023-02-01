using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Bossfight
{
    internal class Program
    {        
     

        static void Main(string[] args)
        {


            var hero = new GameCharacter("Pippi",200, 20, 40);
            var boss = new GameCharacter("El_Bosso",400, 20, 10);

            //boss.InitBossStrength();
            hero.PrintInfo(boss);
            GameCharacter.isAlive = true;
            while (GameCharacter.isAlive)
            {
                hero.Fight(boss);
                boss.Fight(hero);
                Thread.Sleep(500);
            }

            Console.ReadLine();








        }
         
        
            


    }
}
