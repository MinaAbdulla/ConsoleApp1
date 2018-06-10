using Algo;
using Pitch;
using Spacing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
