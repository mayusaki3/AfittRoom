using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Mesh
        {
            public string name { get; set; }
            public Primitive[] primitives { get; set; }
        }
    }
}
