using Algo;
using Algo.Spacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.Pitch;
using Algo.Spacing;
namespace AlgoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData inputDataTrail = new InputData()
            { RoofSpan =120, Species = Species.Hem_fir,
                Grade = Grade.G3, GrSnowLoad = GrSnowLoad._209
              , RoofLength = 1200};

            var Q_Depth=GetPitch_Nails.GetSpacing(inputDataTrail);
            var Q_Pitches = GetPitch_Nails.GetPitch(Helper.ConvertRafterCellToOutput(Q_Depth));
            /*.RafterSpan.ToInch(),(RafterSpacing_p)Q_Depth[0].RafterSpacing,
                        inputDataTrail.GrSnowLoad);*/
            //var Q_Pitches2 = GetPitch_Nails.GetPitch(60,RafterSpacing_p._12, GrSnowLoad._209);

            OutPut trial = new OutPut(inputDataTrail);
            var L = trial.Input.RoofLength = 42 * 12;
            var RSpan = trial.RafterSpan = 15 * 12;
            //GetPitch_Nails.GetPitch(); 

            var RSpac = trial.RafterSpacing = 16;
            var RD = trial.RafterDepth = 8;
            var P = trial.Pitch = 8;
            double Vol = trial.CalculateVolume(L, (int)RSpan, RSpac, RD, P);
            Console.WriteLine("Total Volume = {0}", Vol);

            OutPut costFunction = new OutPut(inputDataTrail);
            var CBf = costFunction.Input.CostPerOneBoardFeet = 3;
            var CPN = costFunction.Input.CostPerOneNail = 0.5;
            var NNo = costFunction.NailsNo = 10;
            var VTot = costFunction.VOL_total;
            var totCost = costFunction.CalculateCost();

            Console.WriteLine("Total Cost = {0} $", totCost);
            Console.Read();
        }
    }
}
