using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Primitive
        {
            public int mode { get; set; }
            public int indices { get; set; }
            public Attributes attributes { get; set; }
            public int material { get; set; }
            public Target[] targets { get; set; }
            public Extras extras { get; set; }
        }
    }
}
