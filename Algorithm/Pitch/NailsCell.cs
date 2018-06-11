using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    namespace Pitch
    {
        public class NailsCell
        {
            public RafterPitch RafterPitch { get; set; }
            public RafterSpacing_p RafterSpacing_p { get; set; }
            public GrSnowLoad GrSnowLoad { get; set; }
            public int RoofSpan_P { get; set; }
            public int NailsNo { get; set; }
        }
        public enum RafterPitch
        {
            _3 = 3, _4 = 4, _5 = 5, _7 = 7, _9 = 9, _12 = 12
        }
        public enum GrSnowLoad
        {
            _209 = (int)20.9, _30, _50, _70
        }
        public enum RafterSpacing_p
        {
            _12 = 12, _16 = 16, _24 = 24
        }
    }
}