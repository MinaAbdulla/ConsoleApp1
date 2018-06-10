using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spacing;
using SpacingTable.Pitch;

namespace SpacingTable
{
    public static class GetSpacing_Depth

    {
        // to Get all possible Solution ( Spacing - Depth ) according to the input depth 
        public static void GetSpacing()
        {
            string s = @"..\..\table01.txt";
            RafterTable Rtb = new RafterTable();
            Rtb.Load(s);
            Length L = new Length(5, 0);
           
            var Span = Rtb.Cells.Where(e => e.RafterSpan.ToInch() == L.ToInch()
                                            && e.Species == Species.Hem_fir).OrderBy(v => v.RafterDepth).ToList();

            for (int j = 0; j < Span.Count(); j++)
            {
             Console.WriteLine(" Solution no {0} is Spacing : {1} \n Rafter Depth : {2}",j,Span[j].RafterSpacing, Span[j].RafterDepth);
            }
        }

    }
}
