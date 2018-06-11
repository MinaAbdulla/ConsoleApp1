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
        public static List<RafterCell> GetSpacing(double Rafter_Span , Species species, Grade grade)
        {
            List<RafterCell> ResRafterCells = new List<RafterCell>();
            string s = @"..\..\table01.txt";
            RafterTable Rtb = new RafterTable();
            Rtb.Load(s);
            //Length L = new Length(5, 0);

            ResRafterCells = Rtb.Cells.Where(e => e.RafterSpan.ToInch() == Rafter_Span
                                               && e.Species==species 
                                               && e.Grade== grade 
                                               
                                            ).OrderBy(v => v.RafterDepth).ToList();

            return ResRafterCells; 
        }
        public static List<NailsCell> GetPitch(double Span, RafterSpacing_p Spacing, GrSnowLoad grSnowLoad)
        {
            List<NailsCell> ResNailsCells = new List<NailsCell>();
            var s = @"..\..\nails.txt";
            NailsTable ntb = new NailsTable();
            ntb.Load(s);
          //  var Span = Math.Round(12,2,MidpointRounding.ToEven);
            ResNailsCells = ntb.nailsCells.Where(e => (e.RoofSpan_P >= (int)Span * 2.4 / 12)
                                                 && e.RafterSpacing_p == Spacing
                                                 && e.GrSnowLoad == grSnowLoad )
                                                    .OrderBy(v=>v.RafterPitch).ToList();
            return ResNailsCells;
        }
        // to Get all possible Solution ( Spacing - Depth ) according to the input depth 
    }
}
