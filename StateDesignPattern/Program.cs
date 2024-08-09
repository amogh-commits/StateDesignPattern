using StateDesignPattern.Model;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            trafficLight.ReportState(); 

            trafficLight.Change();   
            trafficLight.ReportState(); 

            trafficLight.Change();      
            trafficLight.ReportState(); 

            trafficLight.Change();      
            trafficLight.ReportState(); 
        }
    }

}