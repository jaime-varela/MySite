using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaimeVarela.Models;

namespace JaimeVarela.Controllers
{
    public class PhysicsController : Controller
    {
        [HttpGet]
        public IActionResult TwinParadoxStoP()
        {
            string mymessage= "This function calculates ...";
            return RedirectToAction("TwoFunctionResult","Results",new {message = mymessage,});
        }
    }
}