using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StateDesignPattern.Model
{
    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight()
        {
            _state = new RedState(); 
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        public void Change()
        {
            _state.Change(this);
        }

        public void ReportState()
        {
            _state.ReportState();
        }
    }

}
