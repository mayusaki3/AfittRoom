using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Skin
        {
            public int inverseBindMatrices { get; set; }
            public int[] joints { get; set; }
            public int skeleton { get; set; }
        }
    }
}
