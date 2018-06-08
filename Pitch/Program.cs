﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitch
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = @"..\..\nails.txt";
            NailsTable ntb = new NailsTable();
            ntb.Load(s);
            var _ntb = ntb.nailsCells.Where(e => //e.GrSnowLoad == GrSnowLoad._209
                                                //&& e.RafterPitch == RafterPitch._3
                                                e.RafterSpacing_p ==RafterSpacing_p._12
                                                && e.RoofSpan_P == 12).ToList();
            //  Console.WriteLine("");
            //Console.WriteLine("Done \n grade:{0}\n species : {1} \n cross-Section :2* {2}", mtb.Grade, mtb.Species, mtb.RafterDepth);
            Console.WriteLine("Count : {0}",_ntb.Count());
            for (int i = 0; i < _ntb.Count(); i++)
            {
                Console.WriteLine("{0}", _ntb[i].NailsNo);
                //Console.WriteLine("Done {0} element No : {1} \n spacong: {2}", _ntb.Count(),
                //    _ntb[i].RafterPitch,_ntb[i].RafterSpacing_p,_ntb[i].RoofSpan_P);}
            }
                Console.Read();
        }
    }
}