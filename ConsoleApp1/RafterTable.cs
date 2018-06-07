using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacing
{
    //fffffffffffffffffffffff
    public class RafterTable
    {
        public List<RafterCell> Cells { get; set; }
        public RafterTable()
        {
            Cells = new List<RafterCell>();
        }
        public void Load(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);
            var Spacings = data[0].Split(',');
            var Depth = data[1].Split(',');
            var DeadLoad = data[2].Split(',');
            Species[] SpArr = {Species.Douglas_fir_larch,Species.Hem_fir
                    ,Species.Southern_pine,Species.Spruce_pine_fir};
            Grade[] GrArr = { Grade.G1, Grade.G2, Grade.G3, Grade.SS };
            var values = data.Skip(3).ToArray();
                           
                for (int j = 0; j < values.Length; j++)
                {
                    var lineSplitted = values[j].Split(' ');
                    for (int i = 2; i < lineSplitted.Length; i++)
                    {
                        var spanSplitted = lineSplitted[i].Split('-');
                        Cells.Add(new RafterCell()
                        {
                            Species = GetSpecies(lineSplitted[0]),
                            Grade = GetGrade(lineSplitted[1]),
                            RafterDepth = Convert.ToDouble(Depth[i - 2]),
                            RafterSpacing = Convert.ToDouble(Spacings[(int)(j / 16)]),
                            DeadLoad = Convert.ToDouble(DeadLoad[(int)((i-2) / 5)]),
                            RafterSpan = new Length(Convert.ToDouble(spanSplitted[0]),Convert.ToDouble(spanSplitted[1]))
                        });
                    }
                }
            
        }
        public List<double> GetSpacings(double depth, Grade grade, Species species, Length rafterSpan)
        {
            return Cells.Where(e => e.RafterDepth == depth &&
                                  e.Grade == grade &&
                                  e.Species == species &&
                                  e.RafterSpan == rafterSpan)
                                  .Select(v => v.RafterSpacing).ToList();
        }
        private Species GetSpecies(string value)
        {
            Species res;
            if (value.Contains("Southern_pine"))
            {
                res = Species.Southern_pine;
            }
            else if (value.Contains("Douglas_fir-larch"))
            {
                res = Species.Douglas_fir_larch;
            }
            
                else if (value.Contains("Hem-fir"))
            {
                res = Species.Hem_fir;
            }
            else
            {
                res = Species.Spruce_pine_fir;
            }

            return res;
        }
        private Grade GetGrade(string value)
        {
            Grade res = Grade.G3;
            if (value.Contains("SS"))
            {
                res = Grade.SS;
            }
            else if (value.Contains("#1"))
            {
                res = Grade.G1;
            }
            else if (value.Contains("#2"))
            {
                res = Grade.G2;
            }
            else if (value.Contains("#3"))
            {
                res = Grade.G3;
            }
            return res;
        }
    }
}
