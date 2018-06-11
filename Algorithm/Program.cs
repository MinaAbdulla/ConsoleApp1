using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
        static void Main1(string[] args)
        {
           InputData input = new InputData();
           OutPut  trial = new OutPut ( input);
           var L = trial.Input.RoofLength = 42 * 12;
           var RSpan = trial.RafterSpan = 15 * 12;
           var RSpac = trial.RafterSpacing = 16;
           var RD = trial.RafterDepth = 8;
           var P = trial.Pitch = 8;
           double Vol = trial.CalculateVolume(L, (int)RSpan, RSpac, RD, P);
           Console.WriteLine("Total Volume = {0}", Vol);
           
           OutPut  costFunction = new OutPut (input);
           var CBf= costFunction.Input.CostPerOneBoardFeet= 3;
           var CPN= costFunction.Input.CostPerOneNail = 0.5;
           var NNo= costFunction.NailsNo= 10;
           var VTot= costFunction.VOL_total = Vol;
           var totCost = costFunction.CalculateCost(CBf, CPN, NNo, VTot);

           Console.WriteLine("Total Cost = {0} $", totCost);
           Console.Read();
        }
    }
}
