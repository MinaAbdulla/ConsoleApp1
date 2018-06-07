﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class RafterCell
    {
        public double RafterSpacing { get; set; }
        public double RafterDepth{ get; set; }
        public double DeadLoad { get; set; }
        public Species Species { get; set; }
        public Grade Grade { get; set; }
        public Length RafterSpan { get; set; }
             
    }
    public enum Species
    {
        Southern_pine,
        Spruce_pine_fir,
        Douglas_fir_larch,
        Hem_fir
    }
    public enum Grade
    {
        SS,G1,G2,G3 
    }

}
