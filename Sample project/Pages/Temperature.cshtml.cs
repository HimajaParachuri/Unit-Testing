using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample_project.Models;
namespace Sample_project.Pages
{
    public class TemperatureModel : PageModel
    {
        public double temperatureCelsius;
        public double temperatureFahrenheit;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            temperatureCelsius = Convert.ToDouble(Request.Form["TemperatureCelsius"]);
            temperatureFahrenheit = TemperatureModel.CelciusToFahrenheit(temperatureCelsius);
        }

        private static double CelciusToFahrenheit(double temperatureCelsius)
        {
            throw new NotImplementedException();
        }
    }
}
