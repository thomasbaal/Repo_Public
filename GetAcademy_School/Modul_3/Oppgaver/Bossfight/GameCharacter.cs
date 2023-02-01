using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bossfight
{
    public class GameCharacter
    {
        static readonly Random Random = new Random();
        public string  Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        public static bool isAlive = false;
        public static int damage = 5;
        public int StartingStamina { get; set; }    
        public bool usedRecharge = false;   


        // Create Characters
        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;    
            Health = health;
            Strength = strength;    
            Stamina = stamina;
            StartingStamina = stamina;
        }

        public void Fight(GameCharacter enemy)
        {
            
            if (Stamina != 0)
            {
                enemy.Health -= Strength;
                Stamina -= 10;
                Console.WriteLine($"--> {Name} hits {enemy.Name} with {Strength} damage, {enemy.Name} now has {enemy.Health} health Left <-- ");
                checkForWinner(enemy);
            }
            else
            {
                Recharge();
            }
            
        }
        public void Recharge()
        {
            Stamina = StartingStamina;
            Console.WriteLine($"{Name} Recharged back to {Stamina}");
        }

        public void checkForWinner(GameCharacter enemy)
        {
            if (Health <= 0)
            {
                Console.WriteLine(enemy.Name + " Is the winner" );
                isAlive = false;
            }
            if (enemy.Health <= 0)
            {
                Console.WriteLine(Name + " Is the winner");
                isAlive = false;
            }
        }

        //public void Fight(GameCharacter enemy)
        // {
        //    // check if game is on or not.
        //    if (isAlive)
        //    {
        //     // fight running if below 0 health.
        //    while (Health > 0 && enemy.Health > 0 && isAlive == true)
        //    {
        //        // keep running while stamina is above 10 or run recharge.
        //        while (Stamina >= 10 && enemy.Stamina >= 10)
        //        {
        //            int delay = Random.Next(1000, 3000);
        //                Thread.Sleep(delay);

        //                while (usedRecharge != true || enemy.usedRecharge != true)
        //            {
        //                if (usedRecharge != true)
        //                {
        //                    enemy.Health -= Strength;
        //                    Stamina -= 10;
        //                    Console.WriteLine($"--> {Name} hits {enemy.Name} with {Strength} damage, {enemy.Name} now has {enemy.Health} health Left <-- ");
        //                    Console.WriteLine();
        //                    //Console.WriteLine($"Both Health's: {Health} | {enemy.Health}");

        //                }
        //                if (enemy.usedRecharge != true)
        //                {
        //                    Health -= enemy.Strength;
        //                    enemy.Stamina -= 10;
        //                    Console.WriteLine($"--> {enemy.Name} hits {Name} with {enemy.Strength} damage, {Name} now has {Health} health Left <--");
        //                    Console.WriteLine();
        //                    //Console.WriteLine($"Both Health's: {Health} | {enemy.Health}");
        //                }
        //                this.usedRecharge = false;
        //                enemy.usedRecharge = false;
        //                //enemy.Health -= Strength;
        //                //Stamina -= 10;
        //                //Console.WriteLine($"{Name} hits {enemy.Name} with {Strength} damage, {enemy.Name} now has {enemy.Health - Strength} health Left ");
        //                ////Console.WriteLine($"Both Health's: {Health} | {enemy.Health}");
        //                //Health -= enemy.Strength;
        //                //enemy.Stamina -= 10;
        //                //Console.WriteLine($"{enemy.Name} hits {Name} with {enemy.Strength} damage, {Name} now has {Health - enemy.Strength} health Left ");
        //                //Console.WriteLine($"Both Health's: {Health} | {enemy.Health}");
        //                //Fight(enemy);
        //                break;
        //            } 
        //            break;
        //        }
        //        Recharge(enemy);

        //    }

        //    // checking who is the winner.
        //    if (Health <= 0)
        //    {
        //        Console.WriteLine($"{enemy.Name} is the winner ! ");
        //        isAlive = false;
        //        //Fight(enemy);
                
        //    }
        //    else if (enemy.Health <= 0)
        //    {
        //        Console.WriteLine($"{Name} is the winner !");
        //        isAlive = false;
        //        //Fight(enemy);
        //    }

        //    }
        //    else return;

        // }

       
        //public void Recharge(GameCharacter enemy)
        //{
        //    if (Stamina < 10)
        //    {   
        //        Stamina = StartingStamina;
        //        this.usedRecharge = true;
        //        Console.WriteLine($"{Name} Recharged back to {StartingStamina}");
        //        Console.WriteLine();
        //    }
        //    else if(enemy.Stamina < 10)
        //    {
        //        enemy.Stamina = enemy.StartingStamina;
        //        enemy.usedRecharge = true;
        //        Console.WriteLine($"{enemy.Name} Recharged back to {StartingStamina}");
        //        Console.WriteLine();
        //    }
        //}

        public void PrintInfo(GameCharacter enemy)
        {
            Console.WriteLine($"------------------------------- Starting Stats for {Name} ! -------------------------------");
            Console.WriteLine($"Health   : {Health}");
            Console.WriteLine($"Strength : {Strength}");
            Console.WriteLine($"Stamina  : {Stamina}");

            Console.WriteLine($"------------------------------- Starting Stats for {enemy.Name} ! -------------------------------");
            Console.WriteLine($"Health   : {enemy.Health}");
            Console.WriteLine($"Strength : {enemy.Strength}");
            Console.WriteLine($"Stamina  : {enemy.Stamina}");
            Console.WriteLine();
            Task.Delay(2000).Wait();
        }

        public void InitBossStrength()
        {
            int strength = Random.Next(0, 30);
            Strength = strength;
        }


    }
}


