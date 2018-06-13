using Algo.Spacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo.Pitch;
using Algo.Spacing;
namespace Algo
{
    public class Algorithm
    {
        public List<OutPut> Outputs { get; set; }
        private RafterTable RafterTable;
        private NailsTable NailsTable;
        public InputData Input { get; set; }

        public void Run()
        {
            InputData inputData = new InputData()
            { RoofSpan = 60, Species = Species.Hem_fir, Grade = Grade.G3, GrSnowLoad = GrSnowLoad._209 };
            //var Q_pitches = GetPitch_Nails.GetSpacing(inputData.RoofSpan, inputData.Species, inputData.Grade);
            var Q_Depth = GetPitch_Nails.GetSpacing(inputData);
            // OutPut outPut1 = Helper.ConvertNailsCellToOutput(Q_Depth);
            List<OutPut> outPut1 = new List<OutPut>();
            outPut1 = Helper.ConvertRafterCellToOutput(Q_Depth);
            for (int i = 0; i < Q_Depth.Count(); i++)
            {
                var Q_Pitches = GetPitch_Nails.GetPitch(outPut1);
                OutPut out2 = new OutPut(inputData);
            }
            // GetPitch_Nails.GetPitch(20, RafterSpacing_p._12,);
        }

        public Algorithm(InputData input)
        {
            Input = input;
            Outputs = new List<OutPut>();
            RafterTable = new RafterTable();
            RafterTable.Load(RafterTable.FilePath);
            NailsTable = new NailsTable();
            NailsTable.Load(NailsTable.pFilePath);
            
        }
        public OutPut GetLeastCost()
        {
            return null;
        }
    }
    public static class Helper
    {
        public static Algo.OutPut ConvertNailsCellToOutput(Algo.Pitch.NailsCell nailsCell)
        {
            //  InputData input = new InputData();
            Algo.OutPut outPut = new Algo.OutPut()
            { Input = new InputData(), NailsNo = nailsCell.NailsNo,
                Pitch = (int)nailsCell.RafterPitch, RafterDepth = 0,
                RafterSpacing = (int)nailsCell.RafterSpacing_p,
                RafterSpan = (int)nailsCell.RafterSpacing_p / 2,
                TotalCost = 0, VOL_total=0  };
            
            //outPut.NailsNo = nailsCell.NailsNo;
            //outPut.Pitch = (int)nailsCell.RafterPitch;
            //outPut.Input = null;
            //outPut.RafterDepth = 0;
            //outPut.RafterSpacing = (int)nailsCell.RafterSpacing_p;
            //outPut.RafterSpan = nailsCell.RoofSpan_P * 6;
            //outPut.TotalCost = 0;
            //outPut.VOL_total = 0;

            return outPut;
        }
        public static List< Algo.OutPut > ConvertRafterCellToOutput(List<Algo.Spacing.RafterCell>  rafterCell)
        {
            List<OutPut> outPuts = new List<OutPut>(); 
            for (int i = 0; i < outPuts.Count(); i++)
            {
            Algo.OutPut outPut = new Algo.OutPut()
            {Input = new InputData(),
                NailsNo = 0,
                Pitch = 0,
                RafterDepth = 0,
                RafterSpacing = (int)rafterCell[i].RafterSpacing,
                RafterSpan = (int)rafterCell[i].RafterSpacing / 2,
                TotalCost = 0,
                VOL_total = 0};
            }  
            return outPuts;
        }
    }
}
