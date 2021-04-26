using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Mesh
        {
            public partial class Primitive
            {
                /// <summary>
                /// ターゲット
                /// </summary>
                /// <remarks>
                /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/mesh.primitive.schema.json
                /// <br/>WebGLの場合: drawElements() と drawArrays()
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public class Target
                {
                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? POSITION { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? NORMAL { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? TANGENT { get; set; } = null;
                }
            }
        }
    }
}
