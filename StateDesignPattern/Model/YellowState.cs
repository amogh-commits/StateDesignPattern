using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    public class YellowState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            Console.WriteLine("Changing from Yellow to Red.");
            trafficLight.SetState(new RedState());
        }

        public void ReportState()
        {
            Console.WriteLine("The traffic light is Yellow. Please prepare to stop.");
        }
    }
}
