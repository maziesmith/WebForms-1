using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumOfNumbers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string firstNumber, string secondNumber)
        {
            try
            {
                var result = Calculate(firstNumber, secondNumber);
                ViewData.Add("result", result);
            }
            catch (Exception ex)
            {
                ViewData.Add("Error", ex.Message);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private decimal Calculate(string firstNumber, string secondNumber)
        {
            var x = decimal.Parse(firstNumber);
            var y = decimal.Parse(secondNumber);
            var z = x + y;
            return z;
        }
    }
}