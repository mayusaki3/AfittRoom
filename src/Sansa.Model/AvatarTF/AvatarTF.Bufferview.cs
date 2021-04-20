using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Bufferview
        {
            public int buffer { get; set; }
            public int byteOffset { get; set; }
            public int byteLength { get; set; }
            public int target { get; set; }
        }
    }
}
