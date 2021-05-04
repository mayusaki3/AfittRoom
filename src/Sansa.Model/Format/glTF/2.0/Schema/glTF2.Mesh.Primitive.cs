using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Mesh
        {
            /// <summary>
            /// メッシュのプリミティブ
            /// <br/>与えられたマテリアルでレンダリングされるジオメトリです。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/mesh.primitive.schema.json
            /// <br/>WebGLの場合: drawElements() と drawArrays()
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class Primitive
            {
                /// <summary>
                /// 属性のディクショナリーオブジェクト
                /// <br/>各キーはメッシュ属性のセマンティックに対応し、各値は属性のデータを含むアクセサのインデックスです。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// <br/>最低１つ以上定義します。
                /// </remarks>
                public Attributes attributes { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// The index of the accessor that contains the indices.
                /// The index of the accessor that contains mesh indices.  When this is not defined, the primitives should be rendered without indices using `drawArrays()`.  When defined, the accessor must contain indices: the `bufferView` referenced by the accessor should have a `target` equal to 34963 (ELEMENT_ARRAY_BUFFER); `componentType` must be 5121 (UNSIGNED_BYTE), 5123 (UNSIGNED_SHORT) or 5125 (UNSIGNED_INT), the latter may require enabling additional hardware support; `type` must be `\"SCALAR\"`. For triangle primitives, the front face has a counter-clockwise (CCW) winding order. Values of the index accessor must not include the maximum value for the given component type, which triggers primitive restart in several graphics APIs and would require client implementations to rebuild the index buffer. Primitive restart values are disallowed and all index values must refer to actual vertices. As a result, the index accessor's values must not exceed the following maxima: BYTE `< 255`, UNSIGNED_SHORT `< 65535`, UNSIGNED_INT `< 4294967295`.
                /// </summary>
                public int? indices { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// The index of the material to apply to this primitive when rendering.
                /// </summary>
                public int? material { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public enum Mode : int
                {
                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    POINTS = 0,

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    LINES = 1,

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    LINE_LOOP = 2,


                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    LINE_STRIP = 3,


                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    TRIANGLES = 4,


                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    TRIANGLE_STRIP = 5,

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    TRIANGLE_FAN = 6
                }

                /// <summary>
                /// TODO: 説明
                /// The type of primitives to render.
                /// The type of primitives to render. All valid values correspond to WebGL enums.
                /// </summary>
                public int? mode { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// An array of Morph Targets, each  Morph Target is a dictionary mapping attributes (only `POSITION`, `NORMAL`, and `TANGENT` supported) to their deviations in the Morph Target.
                /// </summary>
                public List<Target> targets { get; set; } = null;

                /// <summary>
                /// エクステンション
                /// </summary>
                public Extensions extensions { get; set; } = null;

                /// <summary>
                /// アプリケーション固有のデータ
                /// </summary>
                public Extras extras { get; set; } = null;
            }
        }
    }
}
