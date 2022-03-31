using ContainerAppMvc.DataAccess;
using ContainerAppMvc.Models.WeatherModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Controllers
{
    public class WeatherAppController : Controller
    {
        private string[] mainCities = new string[] { "İstanbul", "London", "Berlin", "Paris" };

        private readonly IWeatherDal _weatherDal;
        public WeatherAppController(IWeatherDal weatherDal)
        {
            _weatherDal = weatherDal;
        }
        public IActionResult Index()
        {
            return View(GetMainCitiesWeatherInfo());
        }
        public JsonResult GetWeatherData(string cityName)
        {
            if (cityName!=null)
            {
                cityName = cityName.Trim();
            }
            
            return Json(_weatherDal.GetWeatherInfo(cityName).Result);
        }
        public List<WeatherModel> GetMainCitiesWeatherInfo()
        {
            List<WeatherModel> weatherOfMainCities = new ();
            foreach (var mainCity in mainCities)
            {
                var result = _weatherDal.GetWeatherInfo(mainCity).Result;
                weatherOfMainCities.Add(result);
            }
            return weatherOfMainCities;
        }

    }
}
