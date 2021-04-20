using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Jaffa.Diagnostics;

namespace Sansa.Model
{
    /// <summary>
    /// アバター
    /// </summary>
    public partial class AvatarTF
    {
        public class VRM
        {
            public string exporterVersion { get; set; }
            public string specVersion { get; set; }
            public Meta meta { get; set; }
            public Humanoid humanoid { get; set; }
            public Firstperson firstPerson { get; set; }
            public Blendshapemaster blendShapeMaster { get; set; }
            public Secondaryanimation secondaryAnimation { get; set; }
            public Materialproperty[] materialProperties { get; set; }
        }
    }
}
