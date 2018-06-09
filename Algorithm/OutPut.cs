using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// aLL Dimensions are in Inches 
namespace Algo
{
    public class OutPut

    {
        #region main_member_Variables
        public int RoofSpan { get; set; } // Plan Width 
        public double RoofLength { get; set; }
        public int RafterSpan { get; set; }
        // OUTPUT 
        public int RafterSpacing { get; set; }
        public int RafterDepth { get; set; }
        public int NailsNo { get; set; }
        public int Pitch { get; set; }
        // RoofSpan =2 * RafterSpan
        public double TotalCost { get; set; }
        #endregion
        #region for_calc_member_Vars
        public double VOL_total { get; set; }

        public double Cost_board_Feet { get; set; }
        public double Cost_per_oneNail { get; set; }
        #endregion
        #region Constructor 
        public OutPut ()
        {
            
        }
        #endregion
        #region Functions
        //Board_feet = 12"*12"*unit = 144"^3 
        // Average Cost OF one Board = 7$ per one Board_feet
        public double CalculateVolume(double PlanLength, int rafterSpan, int RafterSpacing, int rafterDepth, int pitch)
        {
            double Vol_AllCommnRafters = 0;
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
            Vol_AllCommnRafters = Vol_oneCommonRafter * 2 * (1 + ((RoofLength - rafterSpan) / RafterSpacing));
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
        public double CalculateCost(double cost_board_Feet, double cost_per_oneNail, int nailsNo, double vol_total)
        {
            int RaftersNo = 0;
            RaftersNo = Convert.ToInt32(RoofLength / RafterSpacing) + 1;
            TotalCost = Cost_board_Feet * (VOL_total / 144) +
                Cost_per_oneNail * NailsNo;
            return TotalCost;
        }
        #endregion 

    }
}

