using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitch
{
  public  class Length
    {
        public double Feet { get; set; }
        public double Inch { get; set; }

        public Length(double feet,double inch)
        {
            Feet = feet;
            Inch = inch;
        }
        public double ToInch()
        {
            return Feet * 12 + Inch;
        }
    }
}
