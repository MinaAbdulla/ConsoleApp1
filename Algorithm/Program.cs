using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            CostFunction trial = new CostFunction();
           var L= trial.PlanLength = 42 * 12;
           var RSpan=trial.RafterSpan =15*12 ;
           var RSpac =trial.RafterSpacing = 16;
           var RD= trial.RafterDepth = 8;
           var P =trial.Pitch = 8;
           double Vol =  trial.CalcVolume(L,RSpan,RSpac,RD,P);
            Console.WriteLine("Total Volume = {0}",Vol);
            Console.Read();
        }
    }
}
