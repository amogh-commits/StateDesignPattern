using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    public class GreenState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Changing from Green to Yellow.");
            trafficLight.SetState(new YellowState());
        }

        public void ReportState()
        {
            Console.WriteLine("The traffic light is Green. You can go.");
        }
    }
}
