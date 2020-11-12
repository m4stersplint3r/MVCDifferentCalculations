using Day23_MileageCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Day23_MileageCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MileageCalculator()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Division()
        {
            return View();
        }

        public IActionResult RomanNumeral()
        {
            return View();
        }

        public IActionResult MileageResult(MileageCalculator mc)
        {
            mc.result = mc.mpg * mc.gallons;
            if(mc.distance > mc.result)
            {
                mc.enoughGas = false;
            }
            else
            {
                mc.enoughGas = true;
            }
            return View(mc);
        }

        public IActionResult CalculatorResult(Calculator c)
        {
            if(c.Operand == '+')
            {
                c.Result = c.X + c.Y;
            }
            else if(c.Operand == '-')
            {
                c.Result = c.X - c.Y;
            }
            else if(c.Operand == '*')
            {
                c.Result = c.X * c.Y;
            }
            else if(c.Operand == '/')
            {
                c.Result = c.X / c.Y;
            }
            return View(c);
        }

        public IActionResult DivisionResult(Division d)
        {
            d.Result = d.X / d.Y;
            d.Remainder = d.X % d.Y;
            return View(d);
        }

        public IActionResult RomanNumeralResult(RomanNumeral r)
        {
            string xString = r.Number.ToString();
            if (xString.Length == 4)
            {
                char firstChar = xString[0];
                switch (firstChar)
                {
                    case '1':
                        r.RomanNumeralResult += "M";
                        break;
                    case '2':
                        r.RomanNumeralResult += "MM";
                        break;
                    case '3':
                        r.RomanNumeralResult += "MMM";
                        break;
                    case '4':
                        r.RomanNumeralResult += "MMMM";
                        break;
                    case '5':
                        r.RomanNumeralResult += "MMMMM";
                        break;
                    case '6':
                        r.RomanNumeralResult += "MMMMMM";
                        break;
                    case '7':
                        r.RomanNumeralResult += "MMMMMMM";
                        break;
                    case '8':
                        r.RomanNumeralResult += "MMMMMMMM";
                        break;
                    case '9':
                        r.RomanNumeralResult += "MMMMMMMMM";
                        break;
                    case '0':
                        break;
                    default:
                        break;
                }
                xString = xString.Substring(1);
            }           

            if (xString.Length == 3)
            {
                char firstChar = xString[0];
                switch (firstChar)
                {
                    case '1':
                        r.RomanNumeralResult += "C";
                        break;
                    case '2':
                        r.RomanNumeralResult += "CC";
                        break;
                    case '3':
                        r.RomanNumeralResult += "CCC";
                        break;
                    case '4':
                        r.RomanNumeralResult += "CD";
                        break;
                    case '5':
                        r.RomanNumeralResult += "D";
                        break;
                    case '6':
                        r.RomanNumeralResult += "DC";
                        break;
                    case '7':
                        r.RomanNumeralResult += "DCC";
                        break;
                    case '8':
                        r.RomanNumeralResult += "DCCC";
                        break;
                    case '9':
                        r.RomanNumeralResult += "CM";
                        break;
                    case '0':
                        break;
                    default:
                        break;
                }
                xString = xString.Substring(1);
            }

            if (xString.Length == 2)
            {
                char firstChar = xString[0];
                switch (firstChar)
                {
                    case '1':
                        r.RomanNumeralResult += "X";
                        break;
                    case '2':
                        r.RomanNumeralResult += "XX";
                        break;
                    case '3':
                        r.RomanNumeralResult += "XXX";
                        break;
                    case '4':
                        r.RomanNumeralResult += "XL";
                        break;
                    case '5':
                        r.RomanNumeralResult += "L";
                        break;
                    case '6':
                        r.RomanNumeralResult += "LX";
                        break;
                    case '7':
                        r.RomanNumeralResult += "LXX";
                        break;
                    case '8':
                        r.RomanNumeralResult += "LXXX";
                        break;
                    case '9':
                        r.RomanNumeralResult += "XC";
                        break;
                    case '0':
                        break;
                    default:
                        break;
                }
                xString = xString.Substring(1);
            }
            if (xString.Length == 1)
            {
                char firstChar = xString[0];
                switch (firstChar)
                {
                    case '1':
                        r.RomanNumeralResult += "I";
                        break;
                    case '2':
                        r.RomanNumeralResult += "II";
                        break;
                    case '3':
                        r.RomanNumeralResult += "III";
                        break;
                    case '4':
                        r.RomanNumeralResult += "IV";
                        break;
                    case '5':
                        r.RomanNumeralResult += "V";
                        break;
                    case '6':
                        r.RomanNumeralResult += "VI";
                        break;
                    case '7':
                        r.RomanNumeralResult += "VII";
                        break;
                    case '8':
                        r.RomanNumeralResult += "VIII";
                        break;
                    case '9':
                        r.RomanNumeralResult += "IX";
                        break;
                    case '0':
                        break;
                    default:
                        break;
                }
            }
            return View(r);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
