using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Console;

using System;

namespace ConsoleApp15
{
    class Player
    {
        private readonly string _name;
        private int _points;
        private readonly Random _random;

        public Player(string name, int points, Random random)
        {
            _random = random;
            _name = name;
            _points = points;
        }

        public void Play(Player player2)
        {
            var winner = _random.Next(2) == 0 ? this : player2;
            var loser = winner == this ? player2 : this;
            winner._points += 1;
            loser._points -= 1;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine(_name.PadRight(12) + _points.ToString().PadLeft(3));
        }
    }
}

/*
 En spiller har et navn og et antall poeng. Når to spiller 
mot hverandre, vil den ene miste et poeng og den andre få et 
poeng. Koden under simulerer tre spillere med 10 poeng hver - og ti runder hvor to 
tilfeldige av dem spiller mot hverandre. Metoden Play() skal inneholde en måte å velge en
tilfeldig vinner og taper av de som blir trukket. Vinneren skal få 1 poeng , taperen mister 1 poeng. 
Til slutt vises det hvor mange poeng hver av dem har. Lag klassen Player, slik at koden under fungerer:
 */