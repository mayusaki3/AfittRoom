using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// シーン
        /// TODO: 説明
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/scene.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Scene
        {
            /*


                "$schema": "http://json-schema.org/draft-04/schema",
                "title": "Scene",
                "type": "object",
                "description": "The root nodes of a scene.",
                "allOf": [ { "$ref": "glTFChildOfRootProperty.schema.json" } ],
                "properties": {
                    "nodes": {
                        "type": "array",
                        "description": "The indices of each root node.",
                        "items": {
                            "$ref": "glTFid.schema.json"
                        },
                        "uniqueItems": true,
                        "minItems": 1
                    },
                    "name": { },
                    "extensions": { },
                    "extras": { }

             */
            /// <summary>
            /// ノードリスト（ノードリストのインデックス）
            /// </summary>
            public int?[] nodes { get; set; } = null;




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
