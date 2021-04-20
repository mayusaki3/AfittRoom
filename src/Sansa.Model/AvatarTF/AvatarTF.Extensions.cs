using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Jaffa.Diagnostics;
using System.Runtime.Serialization;

namespace Sansa.Model
{
    /// <summary>
    /// アバター
    /// </summary>
    public partial class AvatarTF
    {
        [DataContract]
        public class Extensions
        {
            public VRM VRM { get; set; }
        }
    }
}
