using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// スキン
        /// TODO: 説明
        /// Joints and matrices defining a skin.
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/skin.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Skin
        {
            /// <summary>
            /// TODO: 説明
            /// The index of the accessor containing the floating-point 4x4 inverse-bind matrices.  The default is that each matrix is a 4x4 identity matrix, which implies that inverse-bind matrices were pre-applied.
            /// </summary>
            public int? inverseBindMatrices { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// The index of the node used as a skeleton root.
            /// </summary>
            /// <remarks>
            /// gltf_detailedDescription": "The index of the node used as a skeleton root. The node must be the closest common root of the joints hierarchy or a direct or indirect parent node of the closest common root.
            /// </remarks>
            public int? skeleton { get; set; } = null;

            /// <summary>
            /// ジョイントリスト（ノードリストのインデックス）
            /// TODO: 説明
            /// Indices of skeleton nodes, used as joints in this skin.
            /// Indices of skeleton nodes, used as joints in this skin.  The array length must be the same as the `count` property of the `inverseBindMatrices` accessor (when defined).
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// "uniqueItems": true
            /// "minItems": 1
            /// </remarks>
            public List<int> joints { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このスキンの名前です。
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
