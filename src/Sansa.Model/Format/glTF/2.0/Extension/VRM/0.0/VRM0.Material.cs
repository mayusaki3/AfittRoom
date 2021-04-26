using Sansa.Model.FormatHelper;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                /// <summary>
                /// VRM拡張
                /// TODO: 説明
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.material.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class Material
                {

                    /*


                        "title": "vrm.material",
                        "type": "object",
                        "properties": {
                            "name": {
                                "type": "string"
                            },
                            "shader": {
                                "description": "This contains shader name.  VRM/MToon, VRM/UnlitTransparentZWrite, and VRM_USE_GLTFSHADER (and legacy materials as Standard, UniGLTF/UniUnlit, VRM/UnlitTexture, VRM/UnlitCutout, VRM/UnlitTransparent) . If VRM_USE_GLTFSHADER is specified, use same index of gltf's material settings",
                                "type": "string"
                            },
                            "renderQueue": {
                                "type": "integer"
                            },
                            "floatProperties": {
                                "type": "object",
                                "additionalProperties": {
                                    "type": "number"
                                }
                            },
                            "vectorProperties": {
                                "type": "object",
                                "additionalProperties": {
                                    "type": "array",
                                    "items": {
                                        "type": "number"
                                    }
                                }
                            },
                            "textureProperties": {
                                "type": "object",
                                "additionalProperties": {
                                    "type": "integer"
                                }
                            },
                            "keywordMap": {
                                "type": "object",
                                "additionalProperties": {
                                    "type": "boolean"
                                }
                            },
                            "tagMap": {
                                "type": "object",
                                "additionalProperties": {
                                    "type": "string"
                                }
                            }

                     */


                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public string name { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public int? renderQueue { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public string shader { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public FloatProperties floatProperties { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public VectorProperties vectorProperties { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public TextureProperties textureProperties { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public KeywordMap keywordMap { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
                    public TagMap tagMap { get; set; } = null;
                }
            }
        }
    }
}

