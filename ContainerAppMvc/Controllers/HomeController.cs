using ContainerAppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            List<AppModel> appModels = new()
            {
              
                new (name: "BMI Calculator", primaryColor: "#a9c25d", secondaryColor: "#AAAAAA", description: "You can calculate your body mass index.", imageName: "bmiCalculator-app.png", appUrl: "BmiCalculatorApp"),
                new (name: "Random Quotes", primaryColor: "#8d9db6", secondaryColor: "#b6bcc2cb", description: "You can generate a random quote for sharing", imageName: "randomQuotes-app.png", appUrl: "RandomQuotesApp"),
                new(name: "Weather App", primaryColor: "white", secondaryColor: "#4B515D", description: "You can get weather information from this application.", imageName: "weather-app.png", appUrl: "WeatherApp"),
                new (name: "Todo", description: "A basic todo app", primaryColor: "#ff6793", secondaryColor: "rgba(0, 0, 0, .8)", imageName: "todo-app.png", appUrl: "TodoApp"),

            };
            return View(appModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
