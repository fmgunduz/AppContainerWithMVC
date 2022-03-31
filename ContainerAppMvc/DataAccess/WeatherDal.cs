using ContainerAppMvc.Models.WeatherModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ContainerAppMvc.DataAccess
{
    public class WeatherDal:IWeatherDal
    {
        private readonly string  apiUrl = "http://api.openweathermap.org/data/2.5/weather";
        private readonly string apiKey = "3ea96a7555748ffb22671d9269aeaa8f";

    
        public async Task<WeatherModel> GetWeatherInfo(string cityName)
        {
            string fullUrl = string.Format("{0}?q={1}&&appid={2}&&lang=tr",apiUrl,cityName, apiKey);
            using (HttpClient httpClient = new ())
            {
                var response = await httpClient.GetAsync(fullUrl);
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WeatherModel>(result);
            }
        }
    }
}
