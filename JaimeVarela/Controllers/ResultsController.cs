using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JaimeVarela.Controllers
{
    public class ResultsController : Controller
    {
        [HttpGet]
        public IActionResult TwoFunctionResult(string message, string param1, string param2,string result)
        {

            return View();
        }
    }
}