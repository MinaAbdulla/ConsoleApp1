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
            InputData inputData = new InputData()
            { RoofSpan = 60,Species = Species.Hem_fir ,Grade =Grade.G3,GrSnowLoad =GrSnowLoad._209};

            var Q_Depth=GetPitch_Nails.GetSpacing(inputData.RoofSpan,inputData.Species,inputData.Grade);
            var Q_Pitches = GetPitch_Nails.GetPitch(Q_Depth[0].RafterSpan.ToInch()*2.4/12,
                                                      (RafterSpacing_p)Q_Depth[0].RafterSpacing,
                                                      inputData.GrSnowLoad);

            // var Q_Pitches = GetPitch_Nails.GetPitch(12,RafterSpacing_p._12, GrSnowLoad._209);

            InputData input = new InputData();
            OutPut trial = new OutPut(input);
            var L = trial.Input.RoofLength = 42 * 12;
            var RSpan = trial.RafterSpan = 15 * 12;
            //GetPitch_Nails.GetPitch(); 

            var RSpac = trial.RafterSpacing = 16;
            var RD = trial.RafterDepth = 8;
            var P = trial.Pitch = 8;
            double Vol = trial.CalculateVolume(L, (int)RSpan, RSpac, RD, P);
            Console.WriteLine("Total Volume = {0}", Vol);

            OutPut costFunction = new OutPut(input);
            var CBf = costFunction.Input.CostPerOneBoardFeet = 3;
            var CPN = costFunction.Input.CostPerOneNail = 0.5;
            var NNo = costFunction.NailsNo = 10;
            var VTot = costFunction.VOL_total = Vol;
            var totCost = costFunction.CalculateCost(CBf, CPN, NNo, VTot);

            Console.WriteLine("Total Cost = {0} $", totCost);
            Console.Read();
        }
    }
}
