using System.Collections.Generic;

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
                public List<int> attributes { get; set; } = null;


                /*
                 
    "properties": {
        "attributes": {
            "type": "object",
            "description": "A dictionary object, where each key corresponds to mesh attribute semantic and each value is the index of the accessor containing attribute's data.",
            "minProperties": 1,
            "additionalProperties": {
                "$ref": "glTFid.schema.json"
            }
        },
        "indices": {
            "allOf": [ { "$ref": "glTFid.schema.json" } ],
            "description": "The index of the accessor that contains the indices.",
            "gltf_detailedDescription": "The index of the accessor that contains mesh indices.  When this is not defined, the primitives should be rendered without indices using `drawArrays()`.  When defined, the accessor must contain indices: the `bufferView` referenced by the accessor should have a `target` equal to 34963 (ELEMENT_ARRAY_BUFFER); `componentType` must be 5121 (UNSIGNED_BYTE), 5123 (UNSIGNED_SHORT) or 5125 (UNSIGNED_INT), the latter may require enabling additional hardware support; `type` must be `\"SCALAR\"`. For triangle primitives, the front face has a counter-clockwise (CCW) winding order. Values of the index accessor must not include the maximum value for the given component type, which triggers primitive restart in several graphics APIs and would require client implementations to rebuild the index buffer. Primitive restart values are disallowed and all index values must refer to actual vertices. As a result, the index accessor's values must not exceed the following maxima: BYTE `< 255`, UNSIGNED_SHORT `< 65535`, UNSIGNED_INT `< 4294967295`."
        },
        "material": {
            "allOf": [ { "$ref": "glTFid.schema.json" } ],
            "description": "The index of the material to apply to this primitive when rendering."
        },
        "mode": {
            "description": "The type of primitives to render.",
            "default": 4,
            "gltf_detailedDescription": "The type of primitives to render. All valid values correspond to WebGL enums.",
            "anyOf": [
                {
                    "enum": [ 0 ],
                    "description": "POINTS",
                    "type": "integer"
                },
                {
                    "enum": [ 1 ],
                    "description": "LINES",
                    "type": "integer"
                },
                {
                    "enum": [ 2 ],
                    "description": "LINE_LOOP",
                    "type": "integer"
                },
                {
                    "enum": [ 3 ],
                    "description": "LINE_STRIP",
                    "type": "integer"
                },
                {
                    "enum": [ 4 ],
                    "description": "TRIANGLES",
                    "type": "integer"
                },
                {
                    "enum": [ 5 ],
                    "description": "TRIANGLE_STRIP",
                    "type": "integer"
                },
                {
                    "enum": [ 6 ],
                    "description": "TRIANGLE_FAN",
                    "type": "integer"
                },
                {
                    "type": "integer"
                }
            ]
        },
        "targets": {
            "type": "array",
            "description": "An array of Morph Targets, each  Morph Target is a dictionary mapping attributes (only `POSITION`, `NORMAL`, and `TANGENT` supported) to their deviations in the Morph Target.",
            "items": {
                "type": "object",
                "minProperties": 1,
                "additionalProperties": {
                    "$ref": "glTFid.schema.json"
                },
                "description": "A dictionary object specifying attributes displacements in a Morph Target, where each key corresponds to one of the three supported attribute semantic (`POSITION`, `NORMAL`, or `TANGENT`) and each value is the index of the accessor containing the attribute displacements' data."
            },
            "minItems": 1
        },
                 
                 */



                /// <summary>
                /// TODO: 説明
                /// </summary>
                public int? mode { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public int? indices { get; set; } = null;


                /// <summary>
                /// TODO: 説明
                /// </summary>
                public int? material { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
      //          public Target[] targets { get; set; } = null;




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
