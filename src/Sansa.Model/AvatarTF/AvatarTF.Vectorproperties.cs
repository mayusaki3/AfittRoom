using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Vectorproperties
        {
            public int[] _Color { get; set; }
            public int[] _ShadeColor { get; set; }
            public int[] _MainTex { get; set; }
            public int[] _ShadeTexture { get; set; }
            public int[] _BumpMap { get; set; }
            public int[] _ReceiveShadowTexture { get; set; }
            public int[] _ShadingGradeTexture { get; set; }
            public int[] _SphereAdd { get; set; }
            public int[] _EmissionColor { get; set; }
            public int[] _EmissionMap { get; set; }
            public int[] _OutlineWidthTexture { get; set; }
            public float[] _OutlineColor { get; set; }
        }
    }
}
