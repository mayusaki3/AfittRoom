using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Firstperson
        {
            public int firstPersonBone { get; set; }
            public Firstpersonboneoffset firstPersonBoneOffset { get; set; }
            public object[] meshAnnotations { get; set; }
            public string lookAtTypeName { get; set; }
            public Lookathorizontalinner lookAtHorizontalInner { get; set; }
            public Lookathorizontalouter lookAtHorizontalOuter { get; set; }
            public Lookatverticaldown lookAtVerticalDown { get; set; }
            public Lookatverticalup lookAtVerticalUp { get; set; }
        }
    }
}
