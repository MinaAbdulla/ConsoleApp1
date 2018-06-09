using Spacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            OutPut  trial = new OutPut ();
            var L = trial.RoofLength = 42 * 12;
            var RSpan = trial.RafterSpan = 15 * 12;
            var RSpac = trial.RafterSpacing = 16;
            var RD = trial.RafterDepth = 8;
            var P = trial.Pitch = 8;
            double Vol = trial.CalculateVolume(L, RSpan, RSpac, RD, P);
            Console.WriteLine("Total Volume = {0}", Vol);
           
            OutPut  costFunction = new OutPut ();
           var CBf= costFunction.Cost_board_Feet = 3;
           var CPN= costFunction.Cost_per_oneNail= 0.5;
           var NNo= costFunction.NailsNo= 10;
           var VTot= costFunction.VOL_total = Vol;
           var totCost = costFunction.CalculateCost(CBf, CPN, NNo, VTot);

            Console.WriteLine("Total Cost = {0} $", totCost);
            Console.Read();
        }
    }
}
