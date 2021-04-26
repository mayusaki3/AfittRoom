using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// シーン
        /// TODO: 説明
        /// The root nodes of a scene.
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/scene.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Scene
        {
            /// <summary>
            /// ノードリスト（ノードリストのインデックス）
            /// TODO: 説明
            /// The indices of each root node.
            /// </summary>
            /// <remarks>
            /// "uniqueItems": true
            /// "minItems": 1
            /// </remarks>
            public List<int> nodes { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このシーンの名前です。
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
