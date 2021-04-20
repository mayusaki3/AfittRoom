using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Humanoid
        {
            public Humanbone[] humanBones { get; set; }
            public float armStretch { get; set; }
            public float legStretch { get; set; }
            public float upperArmTwist { get; set; }
            public float lowerArmTwist { get; set; }
            public float upperLegTwist { get; set; }
            public float lowerLegTwist { get; set; }
            public int feetSpacing { get; set; }
            public bool hasTranslationDoF { get; set; }
        }
    }
}
