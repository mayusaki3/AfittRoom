using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Materialproperty
        {
            public string name { get; set; }
            public int renderQueue { get; set; }
            public string shader { get; set; }
            public Floatproperties floatProperties { get; set; }
            public Vectorproperties vectorProperties { get; set; }
            public Textureproperties textureProperties { get; set; }
            public Keywordmap keywordMap { get; set; }
            public Tagmap tagMap { get; set; }
        }
    }
}
