using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Material
        {
            public string name { get; set; }
            public Pbrmetallicroughness pbrMetallicRoughness { get; set; }
            public Normaltexture normalTexture { get; set; }
            public Emissivetexture emissiveTexture { get; set; }
            public int[] emissiveFactor { get; set; }
            public bool doubleSided { get; set; }
            public string alphaMode { get; set; }
            public string extensions { get; set; }
        }
    }
}
