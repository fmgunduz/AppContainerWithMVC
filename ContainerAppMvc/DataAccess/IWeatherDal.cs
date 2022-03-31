using ContainerAppMvc.Models.WeatherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.DataAccess
{
    public interface IWeatherDal
    {
        Task<WeatherModel> GetWeatherInfo(string cityName);
    }
}
