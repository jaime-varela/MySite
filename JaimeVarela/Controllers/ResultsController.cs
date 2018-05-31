using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JaimeVarela.Controllers
{
    public class ResultsController : Controller
    {
        [HttpGet]
        public IActionResult TwoFunctionResult(string message, string param1, string param2,
                                            string result, string param1message, string param2message,
                                            string CallingController, string CallingAction)
        {
            ViewData["message"] = message;
            ViewData["param1message"] = param1message;
            ViewData["param2message"] = param2message;
            ViewData["input1"] = param1;
            ViewData["input2"] = param2;
            ViewData["result"] = result;
            ViewData["CallingController"] = CallingController;
            ViewData["CallingAction"] = CallingAction;
             return View();
        }
    }
}