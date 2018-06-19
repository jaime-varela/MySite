using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaimeVarela.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JaimeVarela.Controllers
{
    public class ComputerScienceController : Controller
    {
        [HttpGet]
        public IActionResult DataStructures()
        {
            string path = "./DataStructures.json";
            string JsonString = System.IO.File.ReadAllText(path);
            var pocoObject = JsonConvert.DeserializeObject<List<DataStructureData>>(JsonString);
            var VM = new DataStructureViewModel(pocoObject);
            return View();
        }
    }
}
