using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.Model
{
    public interface ITrafficLightState
    {
        void Change(TrafficLight trafficLight);
        void ReportState();
    }
}
