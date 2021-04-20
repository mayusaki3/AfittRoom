using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Bonegroup
        {
            public string comment { get; set; }
            public float stiffiness { get; set; }
            public int gravityPower { get; set; }
            public Gravitydir gravityDir { get; set; }
            public float dragForce { get; set; }
            public int center { get; set; }
            public float hitRadius { get; set; }
            public int[] bones { get; set; }
            public int?[] colliderGroups { get; set; }
        }
    }
}
