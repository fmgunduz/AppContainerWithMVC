using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Models.WeatherModels
{
    public class Sys
    {
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public string FormattedTime { 
            get 
            {
                // Unix tipindeki zamanı DateTime a çeviriyoruz.
                DateTime dateTime = new (1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds(this.Sunrise).ToLocalTime();
                return dateTime.ToShortTimeString();
            }
        }
    }
}
