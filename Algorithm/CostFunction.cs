using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
  public  class CostFunction 
    {
        //Board_feet = 12"*12"*unit = 144"^3 
        // Average Cost OF one Board = 7$ per one Board_feet
        public double  Cost_board_Feet{ get; set; }
        public double Cost_per_oneNail{ get; set; }
        public int NailsNo { get; set; }
        public double VOL_total { get; set; }
        public double TotalCost { get; set; }

        public CostFunction()
        {

        }

        public double CalculateCost(double cost_board_Feet, double cost_per_oneNail, int nailsNo, double vol_total)
        {
            TotalCost = Cost_board_Feet * (VOL_total/144) + Cost_per_oneNail * NailsNo;
            return TotalCost;
        }

    }
}
