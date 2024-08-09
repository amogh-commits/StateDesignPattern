using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{

    public class RedState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Changing from Red to Green.");
            trafficLight.SetState(new GreenState());
        }

        public void ReportState()
        {
            Console.WriteLine("The traffic light is Red. Please stop.");
        }
    }
}
