using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            /// <summary>
            /// TODO: 説明
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/tree/master/extensions/2.0/Khronos/KHR_texture_transform
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class KHR_Texture_Transform
            {
                /// <summary>
                /// TODO: 説明(?)
                /// </summary>
                public float?[] offset { get; set; } = null;


                /// <summary>
                /// TODO: 説明(?)
                /// </summary>
                public float? rotation { get; set; } = null;


                /// <summary>
                /// TODO: 説明(?)
                /// </summary>
                public int?[] scale { get; set; } = null;



                /// <summary>
                /// TODO: 説明(?)
                /// </summary>
                public int? texCoord { get; set; } = null;


                /// <summary>
                /// TODO: 説明(?)
                /// </summary>
                public Extensions extensions { get; set; } = null;

                /// <summary>
                /// TODO: 説明(?)
                /// </summary>
                public Extras extras { get; set; } = null;

                /*
                 
 "$schema" : "http://json-schema.org/draft-04/schema",
    "title" : "KHR_texture_transform textureInfo extension",
    "type" : "object",
    "description": "glTF extension that enables shifting and scaling UV coordinates on a per-texture basis",
    "allOf": [ { "$ref": "glTFProperty.schema.json" } ],
    "properties" : {
        "offset": {
            "type": "array",
            "description": "The offset of the UV coordinate origin as a factor of the texture dimensions.",
            "items": {
                "type": "number"
            },
            "minItems": 2,
            "maxItems": 2,
            "default": [ 0.0, 0.0 ]
        },
        "rotation": {
            "type": "number",
            "description": "Rotate the UVs by this many radians counter-clockwise around the origin.",
            "default": 0.0
        },
        "scale": {
            "type": "array",
            "description": "The scale factor applied to the components of the UV coordinates.",
            "items": {
                "type": "number"
            },
            "minItems": 2,
            "maxItems": 2,
            "default": [ 1.0, 1.0 ]
        },
        "texCoord": {
            "type": "integer",
            "description": "Overrides the textureInfo texCoord value if supplied, and if this extension is supported.",
            "minimum": 0
        },
        "extensions": { },
        "extras": { }                 
                 
                 */

                /// TODO: 実装

            }
        }
    }
}
