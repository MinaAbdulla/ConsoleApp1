using Algo.Spacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.Pitch;
using System.Reflection;

namespace Algo.Pitch
{
   public static class GetPitch_Nails
    {
        public static List<RafterCell> GetSpacing(InputData input)
        {
            List<RafterCell> ResRafterCells = new List<RafterCell>();
            string s = @"..\..\table01.txt";
            RafterTable Rtb = new RafterTable();
            Rtb.Load(s);
            //Length L = new Length(5, 0);

            ResRafterCells = Rtb.Cells.Where(e => e.RafterSpan.ToInch() == input.RoofSpan
                                               && e.Species==input.Species
                                               && e.Grade== input.Grade
                                               ).OrderBy(v => v.RafterDepth).ToList();
            return ResRafterCells; 
        }
        public static List<NailsCell> GetPitch(List<OutPut> outPut)
        {
            List<NailsCell> ResNailsCells = new List<NailsCell>();
            var s = @"..\..\nails.txt";
            NailsTable ntb = new NailsTable();
            ntb.Load(s);
            //  var Span = Math.Round(12,2,MidpointRounding.ToEven);
            for (int i = 0; i < outPut.Count(); i++)
            {
            ResNailsCells = ntb.nailsCells.Where(e => 
                        (e.RoofSpan_P ==RoundSpan (outPut[i].RafterSpan))
                        && e.RafterSpacing_p ==(RafterSpacing_p) outPut[i].RafterSpacing
                        && e.GrSnowLoad == outPut[i].Input.GrSnowLoad)
                        .OrderBy(v=>v.NailsNo).ToList();
            }
            return ResNailsCells;
        }
        public static int RoundSpan(double rSpan)
        {

            if ((rSpan/6) <= 12) rSpan = 12;
            else if ((rSpan/6) <= 20 && (rSpan/6) > 12) rSpan = 20;
            else if ((rSpan/6) <= 28 && (rSpan/6) > 20) rSpan = 28;
            else  rSpan = 36;

            //(rSpan/6) Describes ( Roof Span Per Feet ) = RafterSpan *2 /12 

            return Convert.ToInt32(rSpan); 
        }
        //12 20 28 36
        // to Get all possible Solution(Spacing - Depth ) according to the input depth
        public static Algo.OutPut ConvertNailsCellToOutput(Algo.Pitch.NailsCell nailsCell)
        {
            InputData input = new InputData();
            Algo.OutPut outPut = new Algo.OutPut(input);
            outPut.NailsNo = nailsCell.NailsNo;
            outPut.Pitch =(int) nailsCell.RafterPitch;
            outPut.Input = null;
            outPut.RafterDepth = 0;
            outPut.RafterSpacing = (int)nailsCell.RafterSpacing_p;
            outPut.RafterSpan = nailsCell.RoofSpan_P * 6;
            outPut.TotalCost = 0;
            outPut.VOL_total = 0;

            return outPut;
        }
        //public static Algo.OutPut ConvertRafterCellToOutput(Algo.Spacing.RafterCell rafterCell)
        //{
        //    InputData input = new InputData();
        //    Algo.OutPut outPut = new Algo.OutPut(input);
        //    outPut.NailsNo = 0;
        //    outPut.Pitch = 0;
        //    outPut.Input = null;
        //    outPut.RafterDepth = 0;
        //    outPut.RafterSpacing = (int)rafterCell.RafterSpacing;
        //    outPut.RafterSpan = RoundSpan(rafterCell.RafterSpan.ToInch());
        //    outPut.TotalCost = 0;
        //    outPut.VOL_total = 0;

        //    return outPut;
        //}
    }
}
