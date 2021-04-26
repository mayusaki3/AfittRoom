using System.ComponentModel;
using static Sansa.Model.Format.glTF2.Extension.VRM0;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class SecondaryAnimation
            {
                public partial class ColliderGroup
                {
                    /// <summary>
                    /// VRM拡張
                    /// TODO: 説明
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.secondaryanimation.collidergroup.schema.json
                    /// </remarks>
                    /// </summary>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class Collider
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// The local coordinate from the node of the collider group in *left-handed* Y-up coordinate.
                        /// </summary>
                        public Vector3 offset { get; set; } = null;

                        /// <summary>
                        /// TODO: 説明
                        /// The radius of the collider.
                        /// </summary>
                        public float? radius { get; set; } = null;
                    }
                }
            }
        }
    }
}