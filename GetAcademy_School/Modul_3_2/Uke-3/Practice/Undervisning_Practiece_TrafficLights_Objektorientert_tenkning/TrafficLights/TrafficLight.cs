using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class TrafficLight
    {
        public int State { get; private set; }
        public bool isRedOn { get; private set; }
        public bool isYellowOn { get; private set; }
        public bool isGreenOn { get; private set; }
        public TrafficLight()
        {
            State = 0;
            isRedOn = true;
            isYellowOn = false;
            isGreenOn = false;



        }
        public void NextState()
        {
            State++;
            var colorState = (TrafficLightStates)State;

            if (colorState == TrafficLightStates.Red)
            {

            }
            else if (colorState == TrafficLightStates.RedAndYellow)
            {
                isRedOn= true;
                isYellowOn= true;
                isGreenOn= false;
            }
            else if (colorState == TrafficLightStates.Green)
            {
                isRedOn = false;
                isYellowOn = false;
                isGreenOn = true;
            }
            else
            {
                isRedOn = false;
                isYellowOn = true;
                isGreenOn = false;
            }


        }

        public void Show()
        {
            Console.ForegroundColor = isRedOn ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine(Light.TheLight);
            Console.ForegroundColor = isYellowOn ? ConsoleColor.Yellow : ConsoleColor.Gray;
            Console.WriteLine(Light.TheLight);
            Console.ForegroundColor = isGreenOn ? ConsoleColor.Green : ConsoleColor.Gray;
            Console.WriteLine(Light.TheLight);

            Console.WriteLine();

            //var checkState = (TrafficLightStates)State;
            //Console.WriteLine($"{checkState}");

        }


    }


}
