﻿using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// TODO: 説明
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/sampler.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Sampler
        {

            /*

               "$schema": "http://json-schema.org/draft-04/schema",
                "title": "Sampler",
                "type": "object",
                "description": "Texture sampler properties for filtering and wrapping modes.",
                "allOf": [ { "$ref": "glTFChildOfRootProperty.schema.json" } ],
                "properties": {
                    "magFilter": {
                        "description": "Magnification filter.",
                        "gltf_detailedDescription": "Magnification filter.  Valid values correspond to WebGL enums: `9728` (NEAREST) and `9729` (LINEAR).",
                        "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_MAG_FILTER",
                        "anyOf": [
                            {
                                "enum": [ 9728 ],
                                "description": "NEAREST",
                                "type": "integer"
                            },
                            {
                                "enum": [ 9729 ],
                                "description": "LINEAR",
                                "type": "integer"
                            },
                            {
                                "type": "integer"
                            }
                        ]
                    },
                    "minFilter": {
                        "description": "Minification filter.",
                        "gltf_detailedDescription": "Minification filter.  All valid values correspond to WebGL enums.",
                        "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_MIN_FILTER",
                        "anyOf": [
                            {
                                "enum": [ 9728 ],
                                "description": "NEAREST",
                                "type": "integer"
                            },
                            {
                                "enum": [ 9729 ],
                                "description": "LINEAR",
                                "type": "integer"
                            },
                            {
                                "enum": [ 9984 ],
                                "description": "NEAREST_MIPMAP_NEAREST",
                                "type": "integer"
                            },
                            {
                                "enum": [ 9985 ],
                                "description": "LINEAR_MIPMAP_NEAREST",
                                "type": "integer"
                            },
                            {
                                "enum": [ 9986 ],
                                "description": "NEAREST_MIPMAP_LINEAR",
                                "type": "integer"
                            },
                            {
                                "enum": [ 9987 ],
                                "description": "LINEAR_MIPMAP_LINEAR",
                                "type": "integer"
                            },
                            {
                                "type": "integer"
                            }
                        ]
                    },
                    "wrapS": {
                        "description": "s wrapping mode.",
                        "default": 10497,
                        "gltf_detailedDescription": "S (U) wrapping mode.  All valid values correspond to WebGL enums.",
                        "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_WRAP_S",
                        "anyOf": [
                            {
                                "enum": [ 33071 ],
                                "description": "CLAMP_TO_EDGE",
                                "type": "integer"
                            },
                            {
                                "enum": [ 33648 ],
                                "description": "MIRRORED_REPEAT",
                                "type": "integer"
                            },
                            {
                                "enum": [ 10497 ],
                                "description": "REPEAT",
                                "type": "integer"
                            },
                            {
                                "type": "integer"
                            }
                        ]
                    },
                    "wrapT": {
                        "description": "t wrapping mode.",
                        "default": 10497,
                        "gltf_detailedDescription": "T (V) wrapping mode.  All valid values correspond to WebGL enums.",
                        "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_WRAP_T",
                        "anyOf": [
                            {
                                "enum": [ 33071 ],
                                "description": "CLAMP_TO_EDGE",
                                "type": "integer"
                            },
                            {
                                "enum": [ 33648 ],
                                "description": "MIRRORED_REPEAT",
                                "type": "integer"
                            },
                            {
                                "enum": [ 10497 ],
                                "description": "REPEAT",
                                "type": "integer"
                            },
                            {
                                "type": "integer"
                            }
                        ]
                    },
                    "name": { },
                    "extensions": { },
                    "extras": { }
                },
                "gltf_webgl": "`texParameterf()`"


             */



            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? magFilter { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? minFilter { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? wrapS { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? wrapT { get; set; } = null;




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
