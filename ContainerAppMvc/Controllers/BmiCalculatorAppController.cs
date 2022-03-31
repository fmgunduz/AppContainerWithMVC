using ContainerAppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Controllers
{
    public class BmiCalculatorAppController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CalculateResult(int weight, int height)
        {
            BmiModel bmiModel = new();
            bmiModel.BmiResult =Math.Round( Convert.ToDouble(weight) / Math.Pow(Convert.ToDouble(height) / 100, 2),2);
            if (bmiModel.BmiResult is double.NaN )
            {
                bmiModel.BmiResultText = "";
                return Json(bmiModel);
            }
            else if ( bmiModel.BmiResult <= 18.5)
            {
                bmiModel.BmiResultText = "Under weight";
                bmiModel.BmiResultTextColor = "#FF9900";
            }
            else if (bmiModel.BmiResult > 18.5 && bmiModel.BmiResult <= 25)
            {
                bmiModel.BmiResultText = "Normal";
                bmiModel.BmiResultTextColor = "green";
            }
            else if (bmiModel.BmiResult > 25 && bmiModel.BmiResult <= 30)
            {
                bmiModel.BmiResultText = "Over weight";
                bmiModel.BmiResultTextColor = "#d64161";

            }
            else
            {
                bmiModel.BmiResultText = "Obese";
                bmiModel.BmiResultTextColor = "red";
            }
            return Json(bmiModel);
        }
    }
}
