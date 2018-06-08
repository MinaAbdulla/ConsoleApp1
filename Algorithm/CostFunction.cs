using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// aLL Dimensions are in Inches 
namespace Algorithm
{
    public class CostFunction
    {
        public int NailsNo { get; set; }
        public int Pitch { get; set; }
        public int RafterSpacing { get; set; }
        public double PlanLength { get; set; }
        public int RafterSpan { get; set; }
        // RoofSpan =2 * RafterSpan
        public int RafterDepth { get; set; }
        public double Vol_oneCommonRafter { get; set; }
        public double Vol_AllCommnRafters { get; set; }
        public double Vol_OneJackRafterQuarter { get; set; }
        public double Vol_AllJackRafters { get; set; }
        public double VOL_total { get; set; }
        public double Theta { get; set; }
        public Double OverHang { get; set; }
        public int QRafterLenght { get; set; }
        // Note: Width of All Rafter is Constant = 2" 
        public double CalcVolume(double PlanLength,int rafterSpan, int RafterSpacing, int rafterDepth, int pitch )
        {
            Theta =Math.Atan(pitch / 12);
            Vol_oneCommonRafter = 2 * rafterDepth * (OverHang + (rafterSpan / Math.Cos(Theta)));
            Vol_AllCommnRafters = Vol_oneCommonRafter * 2 * (1 + ((PlanLength - rafterSpan) / RafterSpacing));
            //Here we calculate the length of Jack rafter which is incremented by the spacing value gradually 
            for (int i = 0; i <= rafterSpan; i++)
            {
                QRafterLenght += RafterSpacing;
                Vol_OneJackRafterQuarter += (2 * (QRafterLenght+OverHang) * rafterDepth * 2);
            }
            Vol_AllJackRafters = 4 * Vol_OneJackRafterQuarter;
            VOL_total = Vol_AllJackRafters + Vol_AllCommnRafters;
            return VOL_total;

        }
        public CostFunction()
        {

        }
    }
}
