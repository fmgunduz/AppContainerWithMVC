using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Models.WeatherModels
{
    public class Main
    {
        double tempC;
        public double Temp {
            get {
                return tempC;
            } 
            set {
                tempC= Math.Round(value - 273,0);
            }
        }
        public double Humidity { get; set; }
    }
}
