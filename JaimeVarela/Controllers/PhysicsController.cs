using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaimeVarela.Models;
using System;
using MathFunctions;
using PhysicsFunctions;
using JaimeVarela.Filters;

namespace JaimeVarela.Controllers
{
    public class PhysicsController : Controller
    {
        private string _twinParadoxmessage = "Here, we calculate time dilation between a ship traveling at some velocity relative to an oberver.";
        private string _twinParadoxStoP = "This page assumes the input time is the ship time.";
        private string _twinParadoxPtoS = "This page assumes the input time is the observer time.";
        private string _twinparam1 = "Enter the velocity (as a fraction of the speed of light)";
        private string _StoPtime = "Enter ship time (arbitrary units)";
        private string _PtoStime = "Enter observer time (arbitrary units)";

        [HttpGet]
        public IActionResult TwinParadoxStoP()
        {
            string mymessage= _twinParadoxmessage;
            mymessage += _twinParadoxStoP;
            TempData["message"] = mymessage;
            TempData["param1message"] = _twinparam1;
            TempData["CallingAction"] = "TwinParadoxStoP";
            TempData["CallingController"] = "Physics";
            TempData["param2message"] = _StoPtime;
            return RedirectToAction("TwoFunctionResult","Results",new {description = "TwinParadoxStoP"});
        }

        [HttpPost]
        public IActionResult TwinParadoxStoP(string number1,string number2)
        {
            string mymessage= _twinParadoxmessage;
            mymessage += _twinParadoxStoP;
            string myresult = "";
            try
            {
                var num1 = Decimal.Parse(number1);
                var num2 = Decimal.Parse(number2);
                if((num1 > 1 || num1 < 0) || (num2 < 0))
                {
                    myresult = "Invalid parameter ranges";
                }
                else
                {
                    myresult = TimeDilation.TwinParadox(num1,num2,true).ToString();
                }
            }
            catch(Exception e)
            {
                myresult = "Inproper input number or it's beyond the range of decimal precision.";
            }
            TempData["message"] = mymessage;
            TempData["param1message"] = _twinparam1;
            TempData["CallingAction"] = "TwinParadoxStoP";
            TempData["CallingController"] = "Physics";
            TempData["param2message"] = _StoPtime;
            TempData["param1"] = number1;
            TempData["param2"] = number2;
            TempData["result"] = myresult;
            return RedirectToAction("TwoFunctionResult","Results",new {description = "TwinParadoxStoP"});
        }

        [HttpGet]
        public IActionResult TwinParadoxPtoS()
        {
            string mymessage= _twinParadoxmessage;
            mymessage += _twinParadoxPtoS;
            TempData["message"] = mymessage;
            TempData["param1message"] = _twinparam1;
            TempData["CallingAction"] = "TwinParadoxPtoS";
            TempData["CallingController"] = "Physics";
            TempData["param2message"] = _PtoStime;
            return RedirectToAction("TwoFunctionResult","Results",new {description = "TwinParadoxPtoS"});
        }

        [HttpPost]
        public IActionResult TwinParadoxPtoS(string number1,string number2)
        {
            string mymessage= _twinParadoxmessage;
            mymessage += _twinParadoxStoP;
            string myresult = "";
            try
            {
                var num1 = Decimal.Parse(number1);
                var num2 = Decimal.Parse(number2);
                if((num1 > 1 || num1 < 0) || (num2 < 0))
                {
                    myresult = "Invalid parameter ranges";
                }
                else
                {
                    myresult = TimeDilation.TwinParadox(num1,num2,false).ToString();
                }
            }
            catch(Exception e)
            {
                myresult = "Inproper input number or it's beyond the range of decimal precision.";
            }
            TempData["message"] = mymessage;
            TempData["param1message"] = _twinparam1;
            TempData["CallingAction"] = "TwinParadoxPtoS";
            TempData["CallingController"] = "Physics";
            TempData["param2message"] = _PtoStime;
            TempData["result"] = myresult;
            TempData["param1"] = number1;
            TempData["param2"] = number2;
            return RedirectToAction("TwoFunctionResult","Results",new {description = "TwinParadoxPtoS"});
        }

    }
}