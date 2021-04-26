using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            /// <summary>
            /// VRM拡張
            /// TODO: 説明
            /// The setting of automatic animation of string-like objects such as tails and hairs.
            /// </summary>
            /// <remarks>
            /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.secondaryanimation.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class SecondaryAnimation
            {
                /// <summary>
                /// TODO: 説明
                /// The setting of automatic animation of string-like objects such as tails and hairs.
                /// </summary>
                public List<Spring> boneGroups { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public List<ColliderGroup> colliderGroups { get; set; } = null;
            }
        }
    }
}
