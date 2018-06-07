using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacing
{
    public class Length
    {
        public Length(double feet, double inch)
        {
            Feet = feet;
            Inch = inch;
        }
        public double Feet { get; set; }
        public double Inch { get; set; }
        public double ToInch()
        {
            return Feet * 12 + Inch;
        } 
    }
}
