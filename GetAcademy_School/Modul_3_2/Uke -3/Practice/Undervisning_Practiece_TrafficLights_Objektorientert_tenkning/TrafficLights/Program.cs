using TrafficLights;



var trafficLight = new TrafficLight();
RunTrafficLightSpaghettiCode(trafficLight);
void RunTrafficLightSpaghettiCode(TrafficLight trafficLight1)
{
    trafficLight1.Show();
    trafficLight1.NextState();
    trafficLight1.Show();
    trafficLight1.NextState();
    trafficLight1.Show();
    trafficLight1.NextState();
    trafficLight1.Show();
}





Console.ReadLine();