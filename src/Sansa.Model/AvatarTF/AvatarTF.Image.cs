using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Image
        {
            public string name { get; set; }
            public int bufferView { get; set; }
            public string mimeType { get; set; }
        }
    }
}
