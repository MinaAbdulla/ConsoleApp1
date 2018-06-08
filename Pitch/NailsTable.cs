using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitch
{
    public class NailsTable
    {
        public List<NailsCell> nailsCells { get; set; }
        public NailsTable()
        {
            nailsCells = new List<NailsCell>();
        }
        public void Load(string filePath)
        {
            string[] Data = File.ReadAllLines(filePath);
            //var RoofSpan_P = Data[0].Split(',');
            var RoofSpan_P = Data[0].Split(',');
            var RafterPitch = Data[1].Split(',');
            var GrSnowLoad = Data[2].Split(',');
            var RafterSpacing_p = Data[3].Split(',');
            //RafterPitch[] Rpitch = { RafterPitch._3, RafterPitch._4, RafterPitch._5,
            //                          RafterPitch._7, RafterPitch._9, RafterPitch._12 };
            //GrSnowLoad[] GSnowLoad = { GrSnowLoad._209, GrSnowLoad._30, GrSnowLoad._50, GrSnowLoad._70 };
            //RafterSpacing_p[] RafSpacing = { RafterSpacing_p._12, RafterSpacing_p._16, RafterSpacing_p._24 };
            var values = Data.Skip(4).ToArray();
            for (int j = 0; j < values.Length; j++)
            {
                var lineSplited = values[j].Split(' ');
                
                for (int i = 0; i < lineSplited.Length; i++)
                {
                    var ValuesSplitted = values[i].Split(' ');
                    nailsCells.Add(new NailsCell()
                    {
                         RoofSpan_P = Convert.ToInt32(RoofSpan_P[i%4]),
                         RafterPitch = GetPitch(RafterPitch[(j % 3)]),
                         GrSnowLoad = GetSnowLoad(GrSnowLoad[i/5]),
                         RafterSpacing_p = GetRafterSpacing_P(RafterSpacing_p[i%3]),
                         NailsNo = Convert.ToInt32(ValuesSplitted[i])
                    });
                }
            }
        }
        //public List<int> GetNailsNo(int rafetrPitch,double rafterSpacing , double grSnowLoad,int roofSpan_P)
        //{
        //return nailsCells.Where(e => e.RafterPitch == rafetrPitch &&
        //                             e.RafterSpacing_p == rafterSpacing &&
        //                             e.RoofSpan_P == rafterSpacing)
        //                             .Select(v => v.NailsNo).ToList();}
        private RafterPitch GetPitch(string value)
        {
            RafterPitch pitch = new RafterPitch();
            switch (pitch)
            {
                case RafterPitch._3:
                    pitch = RafterPitch._3;
                    break;
                case RafterPitch._4:
                    pitch = RafterPitch._4;
                    break;
                case RafterPitch._5:
                    pitch = RafterPitch._5;
                    break;
                case RafterPitch._7:
                    pitch = RafterPitch._7;
                    break;
                case RafterPitch._9:
                    pitch = RafterPitch._9;
                    break;
                default:
                    pitch = RafterPitch._12;
                    break;
            }
            return pitch;
        }
        private GrSnowLoad GetSnowLoad(string value)
        {
            GrSnowLoad GRSnowLoad = new GrSnowLoad();
            switch (GRSnowLoad)
            {
                case GrSnowLoad._209:
                    GRSnowLoad = GrSnowLoad._209;
                    break;
                case GrSnowLoad._30:
                    GRSnowLoad = GrSnowLoad._30;
                    break;
                case GrSnowLoad._50:
                    GRSnowLoad = GrSnowLoad._50;
                    break;
                case GrSnowLoad._70:
                    GRSnowLoad = GrSnowLoad._70;
                    break;
                default:
                    break;
            }
            return GRSnowLoad;
        }
        private RafterSpacing_p GetRafterSpacing_P(string value)
        {
            RafterSpacing_p RftSpacing = new RafterSpacing_p();
            switch (RftSpacing)
            {
                case RafterSpacing_p._12:
                    RftSpacing =RafterSpacing_p._12;
                    break;
                case RafterSpacing_p._16:
                    RftSpacing = RafterSpacing_p._16;
                    break;
                case RafterSpacing_p._24:
                    RftSpacing = RafterSpacing_p._24;
                    break;
                default:
                    break;
            }
            return RftSpacing;
        }
    }
}
