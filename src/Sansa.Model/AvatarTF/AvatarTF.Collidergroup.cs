using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Collidergroup
        {
            public int node { get; set; }
            public Collider[] colliders { get; set; }
        }
    }
}
