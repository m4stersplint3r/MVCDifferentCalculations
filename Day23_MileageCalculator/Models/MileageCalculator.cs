using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day23_MileageCalculator.Models
{
    public class MileageCalculator
    {
        public double mpg { get; set; }
        public double gallons { get; set; }
        public double distance { get; set; }
        public double result { get; set; }
        public bool enoughGas { get; set; }
    }
}