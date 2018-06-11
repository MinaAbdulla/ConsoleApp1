using Spacing;
using SpacingTable.Pitch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacingTable
{
   public static class GetPitch_Nails
    {
        public static void GetPitch()
        {
            var s = @"..\..\nails.txt";
            NailsTable ntb = new NailsTable();
            ntb.Load(s);
            var _ntb = ntb.nailsCells.Where(e => e.RoofSpan_P == 12
                                                ).ToList();
            var _ntb1 = ntb.nailsCells.Where(e => e.RoofSpan_P == 12
                                                      && e.GrSnowLoad == GrSnowLoad._209
                                                       ).ToList();
            var _ntb3 = ntb.nailsCells.Where(e =>
                     e.RoofSpan_P == 12
                     && e.GrSnowLoad == GrSnowLoad._209
                     && e.RafterSpacing_p == RafterSpacing_p._12
                      ).ToList();
            var _ntb4 = ntb.nailsCells.Where(e =>
                        e.RoofSpan_P == 12
                     && e.GrSnowLoad == GrSnowLoad._209
                     && e.RafterSpacing_p == RafterSpacing_p._12
                     && e.RafterPitch == RafterPitch._3).OrderBy(v => v.RoofSpan_P).ToList();

            var _ntb5 = ntb.nailsCells.Where(e =>
                       e.GrSnowLoad == GrSnowLoad._30
                    && e.RafterSpacing_p == RafterSpacing_p._12
                    && e.RafterPitch == RafterPitch._5
                        ).OrderBy(v => v.RoofSpan_P).ToList();
            //Console.WriteLine("Done \n grade:{0}\n species : {1} \n cross-Section :2* {2}", mtb.Grade, mtb.Species, mtb.RafterDepth);
            Console.WriteLine("Count : {0}", _ntb.Count());
            for (int i = 0; i < _ntb.Count(); i++)
            {
                Console.WriteLine("{0}", _ntb[i].NailsNo);
                //Console.WriteLine("Done {0} element No : {1} \n spacong: {2}", _ntb.Count(),
                //_ntb[i].RafterPitch,_ntb[i].RafterSpacing_p,_ntb[i].RoofSpan_P);}
            }
            Console.Read();
        }
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
                Console.WriteLine(" Solution no {0} is Spacing : {1} \n Rafter Depth : {2}", j, Span[j].RafterSpacing, Span[j].RafterDepth);
            }
        }

    }
}
