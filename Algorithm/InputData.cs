using static Algo.Spacing.RafterCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.Pitch;
using Algo.Spacing;
namespace Algo
{
    public class InputData
    {
        /**************************************************** Form Input**************************/
        public int DeadLoad { get; set; }
        public Species Species { get; set; }
        public Grade Grade{ get; set; }
        public GrSnowLoad GrSnowLoad { get; set; }
        public double  CostPerOneNail{ get; set; }
        public double  CostPerOneBoardFeet{ get; set; }
        /*************************************************From API Project **************************/ 
        public double RoofLength { get; set; }
        public  double RoofSpan { get; set; }
        /************************************************* Constructor */
        public InputData()
        {

        }
        /************************************************* Functions To Get Properties*/
        public double GetRoofSpan()
        {
            return RoofSpan; 
        }
        public double GetRoofLength()
        {
            return RoofLength;
        }
    }
}
