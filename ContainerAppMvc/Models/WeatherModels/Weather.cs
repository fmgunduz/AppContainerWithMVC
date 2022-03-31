using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Models.WeatherModels
{
    public class Weather
    {
        private  string iconUrl = "http://openweathermap.org/img/wn/{0}@2x.png";
        public string Description { get; set; }
        public string Icon { get { return iconUrl; } set { iconUrl = string.Format(iconUrl, value); } }
    }
}
