using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaimeVarela.Models;
using MF = MathFunctions;
using JaimeVarela.Filters;

namespace JaimeVarela.Controllers
{
    [Route("[controller]/[action]")]
    public class ProgramsController : Controller
    {
        private static long maxint = 10000;
        private static long maxfib = 100000;
        private static long maxbin = 118450;//found by finding n s.t  10,000! = (n n/2)

        private string _factorialmessage = "The following form uses ASP.NET's built in big integer library to compute factorials.  Below a certain value (about 500) the factorial is calculated via standard recusion, above that value the factorial is calculated via split-recursive algorithm.";
        private string _enterinteger = "Please Enter an Integer";
        public IActionResult MyPrograms()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Factorial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Factorial(string integer)
        {
            string result = "";
            try
            {                
                var intval = Convert.ToInt64(integer);
                if(intval > maxint)
                    result = "Input integers are limited to be less than " +maxint.ToString() +
                            " in order reduce data and processing loads.  Send an e-mail if you are interested in larger integers.";
                else
                    result = MF.Factorial.FString(intval);
            }
            catch(Exception e)
            {
                result = "Invalid integer or the integer is bigger than LONG_MAX";
            }
            ViewData["result"] = result;
            ViewData["input"] = integer;
            return View();
        }

        [HttpGet]
        public IActionResult Fibonacci()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Fibonacci(string integer)
        {
            string result = "";
            try
            {                
                var intval = Convert.ToInt64(integer);
                if(intval > maxfib)
                    result = "Input integers are limited to be less than " +maxfib.ToString() +
                            " in order reduce data and processing loads.  Send an e-mail if you are interested in larger integers.";
                else
                    result = MF.Fibonacci.FString(intval);
            }
            catch(Exception e)
            {
                result = "Invalid integer or the integer is bigger than LONG_MAX";
            }
            ViewData["result"] = result;
            ViewData["input"] = integer;
            return View();
        }

        [HttpGet]
        public IActionResult BinomialCoeff()
        {
            return View();            
        }

        [HttpPost]
        public IActionResult BinomialCoeff(string number, string knumber)
        {
            string result = "";
            try
            {                
                var intval = Convert.ToInt64(number);
                var kintval = Convert.ToInt64(knumber);
                if(intval > maxbin)
                    result = "Input integers are limited to be less than " +maxbin.ToString() +
                            " in order reduce data and processing loads.  Send an e-mail if you are interested in larger integers.";
                else
                    result = MF.BinomialCoefficient.BinomialString(intval,kintval);
            }
            catch(Exception e)
            {
                result = "Invalid integer or the integer is bigger than LONG_MAX";
            }
            ViewData["result"] = result;
            ViewData["input1"] = number;
            ViewData["input2"] = knumber;
            return View();
        }

    }
}
