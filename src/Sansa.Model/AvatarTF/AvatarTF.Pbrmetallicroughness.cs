using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Pbrmetallicroughness
        {
            public Basecolortexture baseColorTexture { get; set; }
            public int[] baseColorFactor { get; set; }
            public int metallicFactor { get; set; }
            public float roughnessFactor { get; set; }
        }
    }
}
