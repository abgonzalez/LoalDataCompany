using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LocalDataCompany.Models;
using LocalDataCompany.Core;
using System;

namespace LocalDataCompany.Controllers
{
    public class HomeController : Controller
    {
        public object Ensure { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAnswer()
        {
            try
            {
                string[] data = new string[]
              {
                 "AAAc91 % cWwWkLq$1ci3_848v3d__K",
                 "AAAc91AAA",
                 "A_4A_A4c941",
                 "$$$$",
                  ""
            };
                Input input = new Input(data);
                input.Parse();
                return PartialView("ShowOutCome", new StringParseViewModel(input));
            }
            catch (Exception e)
            {
                throw new Exception("Error message" + e);
            }
        }

    }
}
