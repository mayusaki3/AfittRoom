using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        public class Meta
        {
            public string version { get; set; }
            public string author { get; set; }
            public string contactInformation { get; set; }
            public string reference { get; set; }
            public string title { get; set; }
            public int texture { get; set; }
            public string allowedUserName { get; set; }
            public string violentUssageName { get; set; }
            public string sexualUssageName { get; set; }
            public string commercialUssageName { get; set; }
            public string otherPermissionUrl { get; set; }
            public string licenseName { get; set; }
            public string otherLicenseUrl { get; set; }
        }
    }
}
