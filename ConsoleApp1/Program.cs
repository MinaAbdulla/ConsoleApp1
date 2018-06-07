using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = @"..\..\table01.txt";
            RafterTable Rtb = new RafterTable();
            Rtb.Load(s);
            Length L = new Length(5, 0);
            var mtb = Rtb.Cells.Where(e => e.RafterDepth==4&&e.DeadLoad==10 && e.RafterSpan.ToInch() >= L.ToInch()).OrderBy(e => e.RafterSpan.ToInch()).First();
            //var mtb = Rtb.Cells.Where(e => e.Species==Species.Douglas_fir_larch&&e.DeadLoad == 10).ToList();
            Console.WriteLine("Done \n grade:{0}\n species : {1} \n cross-Section :2*{2}",mtb.Grade,mtb.Species,mtb.RafterDepth);
            Console.Read();
        }
    }
}
