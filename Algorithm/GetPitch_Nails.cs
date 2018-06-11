using Algo.Spacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.Pitch;
namespace Algo.Pitch
{
   public static class GetPitch_Nails
    {
        public static List<RafterCell> GetSpacing(double rafterSpan)
        {
            List<RafterCell> ResRafterCells = new List<RafterCell>();
            string s = @"..\..\table01.txt";
            RafterTable Rtb = new RafterTable();
            Rtb.Load(s);
            Length L = new Length(5, 0);

            var Span = Rtb.Cells.Where(e => e.RafterSpan.ToInch() == L.ToInch()
                                            && e.Species == Species.Hem_fir).OrderBy(v => v.RafterDepth).ToList();

            for (int j = 0; j < Span.Count(); j++)
            {
                Console.WriteLine(" Solution no {0} is Spacing : {1} \n Rafter Depth : {2}"
                    , j, Span[j].RafterSpacing, Span[j].RafterDepth);
            }
            return ResRafterCells; 
        }
        public static List<NailsCell> GetPitch(double Span, RafterSpacing_p Spacing)
        {
            List<NailsCell> ResNailsCells = new List<NailsCell>();
            var s = @"..\..\nails.txt";
            NailsTable ntb = new NailsTable();
            ntb.Load(s);
            var _ntb = ntb.nailsCells.Where(e => e.RoofSpan_P == Span && e.RafterSpacing_p ==Spacing).ToList();
            return ResNailsCells;
        }
        // to Get all possible Solution ( Spacing - Depth ) according to the input depth 
    }
}
