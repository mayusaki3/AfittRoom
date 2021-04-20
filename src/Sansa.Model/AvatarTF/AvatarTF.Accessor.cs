using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Accessor
        {
            public int bufferView { get; set; }
            public int byteOffset { get; set; }
            public string type { get; set; }
            public int componentType { get; set; }
            public int count { get; set; }
            public float[] max { get; set; }
            public float[] min { get; set; }
            public bool normalized { get; set; }
        }
    }
}
