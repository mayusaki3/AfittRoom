using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Blendshapegroup
        {
            public string name { get; set; }
            public string presetName { get; set; }
            public bool isBinary { get; set; }
            public Bind[] binds { get; set; }
            public object[] materialValues { get; set; }
        }
    }
}
