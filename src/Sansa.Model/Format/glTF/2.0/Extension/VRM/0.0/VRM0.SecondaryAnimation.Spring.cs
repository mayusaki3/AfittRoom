using System.Collections.Generic;
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
                /// <summary>
                /// VRM拡張
                /// TODO: 説明
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.secondaryanimation.spring.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class Spring
                {
                    /// <summary>
                    /// TODO: 説明
                    /// Annotation comment
                    /// </summary>
                    public string comment { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// The resilience of the swaying object (the power of returning to the initial pose).
                    /// </summary>
                    public float? stiffiness { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// The strength of gravity.
                    /// </summary>
                    public float? gravityPower { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// The direction of gravity. Set (0, -1, 0) for simulating the gravity. Set (1, 0, 0) for simulating the wind.
                    /// </summary>
                    public Vector3 gravityDir { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// The resistance (deceleration) of automatic animation.
                    /// </summary>
                    public float? dragForce { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// The reference point of a swaying object can be set at any location except the origin. When implementing UI moving with warp, the parent node to move with warp can be specified if you don't want to make the object swaying with warp movement.
                    /// </summary>
                    public int? center { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// The radius of the sphere used for the collision detection with colliders.
                    /// </summary>
                    public float? hitRadius { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// Specify the node index of the root bone of the swaying object.
                    /// </summary>
                    public List<int> bones { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// Specify the index of the collider group for collisions with swaying objects.
                    /// </summary>
                    public List<int> colliderGroups { get; set; } = null;
                 }
            }
        }
    }
}

