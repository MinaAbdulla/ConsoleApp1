using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Algo.Pitch;
// aLL Dimensions are in Inches 
namespace Algo
{
    public  class OutPut
    {
        private double _totalCost;
        public Double RafterSpan { get; set; }
        /************************************************ From DepthTable  */
        public int RafterSpacing { get; set; }
        public int RafterDepth { get; set; }
        /************************************************ From NailsTable */
        public int NailsNo { get; set; }
        public int Pitch { get; set; }                           // in form of Value / 12 
        /********************************************************** */
        public double TotalCost { get { return _totalCost = CalculateCost(); } set => _totalCost = value; }
        public double VOL_total { get; set; }
        public InputData Input { get; set; }
        public OutPut(InputData Input)
        {
            this.Input = Input;
            RafterSpan = Input.RoofSpan / 2;
        }
        public OutPut()
        {

        }
        #region Functions
        public double CalculateVolume(double PlanLength, int rafterSpan, int RafterSpacing, int rafterDepth, int pitch)
        {
            double Vol_AllCommnRafters;
            double Vol_OneJackRafterQuarter = 0;
            double Vol_AllJackRafters = 0;
            double VOL_total = 0;
            double Theta = 0;
            Double OverHang = 0;
            int QRafterLenght = 0;
            // Note: Width of All Rafter is Constant = 2" 
            Theta = Math.Atan(pitch / 12);
            double Vol_oneCommonRafter = 0;
            Vol_oneCommonRafter = 2 * rafterDepth * (OverHang + (rafterSpan / Math.Cos(Theta)));
            Vol_AllCommnRafters = Vol_oneCommonRafter * 2 * (1 + ((Input.RoofLength - rafterSpan) / RafterSpacing));
            //Here we calculate the length of Jack rafter which is incremented by the spacing value gradually 
            for (int i = 0; i < rafterSpan / RafterSpacing; i++)
            {
                QRafterLenght += RafterSpacing;
                Vol_OneJackRafterQuarter += (2 * (QRafterLenght + OverHang) * rafterDepth * 2);
            }
            Vol_AllJackRafters = 4 * Vol_OneJackRafterQuarter;
            VOL_total = Vol_AllJackRafters + Vol_AllCommnRafters;
            return VOL_total;

        }
        public double CalculateCost()
        {
            Int32 RaftersNo = 0;
            RafterSpacing = 1;
            RaftersNo = Convert.ToInt32(Input.RoofLength / RafterSpacing) + 1;
            TotalCost = Input.CostPerOneBoardFeet * (VOL_total / 144) +
            Input.CostPerOneNail * NailsNo;
            return TotalCost;
        }
        public double GetLeastCost()
        {
            double OptCost = 0;
            return OptCost;
        }
        #endregion
        // Rafters NO  == [rafterSpan / RafterSpacing]
        //Board_feet = 12"*12"*unit = 144"^3 
        // Average Cost OF one Board = 7$ per one Board_feet
    }
}

