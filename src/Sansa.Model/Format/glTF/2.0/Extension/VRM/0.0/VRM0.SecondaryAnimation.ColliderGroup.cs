using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class SecondaryAnimation
            {
                /// <summary>
                /// VRM拡張
                /// TODO: 説明
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.secondaryanimation.collidergroup.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class ColliderGroup
                {
                    /// <summary>
                    /// TODO: 説明
                    /// The node of the collider group for setting up collision detections.
                    /// </summary>
                    public int? node { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public List<Collider> colliders { get; set; } = null;
                }
            }
        }
    }
}

