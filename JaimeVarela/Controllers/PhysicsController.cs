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
        public IActionResult TwinParadox()
        {
            return View();
        }
    }
}