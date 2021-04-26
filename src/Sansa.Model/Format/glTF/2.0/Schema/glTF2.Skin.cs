using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// スキン
        /// TODO: 説明
        /// 
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/skin.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Skin
        {
            /*


                "$schema": "http://json-schema.org/draft-04/schema",
                "title": "Skin",
                "type": "object",
                "description": "Joints and matrices defining a skin.",
                "allOf": [ { "$ref": "glTFChildOfRootProperty.schema.json" } ],
                "properties": {
                    "inverseBindMatrices": {
                        "allOf": [ { "$ref": "glTFid.schema.json" } ],
                        "description": "The index of the accessor containing the floating-point 4x4 inverse-bind matrices.  The default is that each matrix is a 4x4 identity matrix, which implies that inverse-bind matrices were pre-applied."
                    },
                    "skeleton": {
                        "allOf": [ { "$ref": "glTFid.schema.json" } ],
                        "description": "The index of the node used as a skeleton root.",
                        "gltf_detailedDescription": "The index of the node used as a skeleton root. The node must be the closest common root of the joints hierarchy or a direct or indirect parent node of the closest common root."
                    },
                    "joints": {
                        "type": "array",
                        "description": "Indices of skeleton nodes, used as joints in this skin.",
                        "items": {
                            "$ref": "glTFid.schema.json"
                        },
                        "uniqueItems": true,
                        "minItems": 1,
                        "gltf_detailedDescription": "Indices of skeleton nodes, used as joints in this skin.  The array length must be the same as the `count` property of the `inverseBindMatrices` accessor (when defined)."
                    },
                    "name": { },
                    "extensions": { },
                    "extras": { }
                },
                "required": [ "joints" ]
            }

             */



            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? inverseBindMatrices { get; set; } = null;

            /// <summary>
            /// ジョイントリスト（ノードリストのインデックス）
            /// </summary>
            public int?[] joints { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? skeleton { get; set; } = null;




            /// <summary>
            /// 名前
            /// <br/>このアクセサの名前です。
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
