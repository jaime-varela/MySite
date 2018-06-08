using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JaimeVarela.Filters;
using Microsoft.AspNetCore.Mvc;

namespace JaimeVarela.Controllers
{
    public class ResultsController : Controller
    {
        [HttpGet]
        public IActionResult OneFunctionResult(string decription)
        {
            ViewData["message"] = TempData["message"];
            ViewData["param1message"] = TempData["param1message"];
            ViewData["input1"] = TempData["param1"];
            ViewData["result"] = TempData["result"];
            ViewData["CallingController"] = TempData["CallingController"];
            ViewData["CallingAction"] = TempData["CallingAction"];
            return View();
        }

        [HttpGet]
        public IActionResult TwoFunctionResult(string description)
        {
            ViewData["message"] = TempData["message"];
            ViewData["param1message"] = TempData["param1message"];
            ViewData["input1"] = TempData["param1"];
            ViewData["result"] = TempData["result"];
            ViewData["CallingController"] = TempData["CallingController"];
            ViewData["CallingAction"] = TempData["CallingAction"];
            ViewData["param2message"] = TempData["param2message"];
            ViewData["input2"] = TempData["param2"];
            return View();
        }
    }
}