using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// メッシュ
        /// <br/>レンダリングされるプリミティブのセットです。
        /// <br/>ノードは1つのメッシュを含むことができます。
        /// <br/>ノードのトランスフォームは、メッシュをシーンに配置します。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/mesh.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Mesh
        {
            /// <summary>
            /// プリミティブのリスト
            /// <br/>マテリアルでレンダリングされるジオメトリを定義します。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>最低１つ以上定義します。
            /// </remarks>
            public List<Primitive> primitives { get; set; } = null;

            /// <summary>
            /// ウェイト
            /// <br/>Morph Targetsに適用されるウェイトのリストです。
            /// </summary>
            /// <remarks>
            /// 指定する場合、最低１つ以上定義します。
            /// </remarks>
            public List<float> weights { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このメッシュの名前です。
            /// </summary>
            public string name { get; set; } = null;

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
