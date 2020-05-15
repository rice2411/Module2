using System;
using System.Collections.Generic;
using System.Text;

namespace ReadJSonFile
{
    class PayLoad
    {
        public List<MathScore> Maths { get; set; }
        public List<ChemistryScore> Chemistries { get; set; }
        public List<PhysicalScore> Physicals { get; set; }
    }
}
