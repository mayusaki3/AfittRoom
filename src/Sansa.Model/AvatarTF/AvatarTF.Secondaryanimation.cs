using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Secondaryanimation
        {
            public Bonegroup[] boneGroups { get; set; }
            public Collidergroup[] colliderGroups { get; set; }
        }
    }
}
