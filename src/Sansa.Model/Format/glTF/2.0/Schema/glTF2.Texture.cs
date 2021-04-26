using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// テクスチャー
        /// TODO: 説明
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/texture.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Texture
        {

            /*

              "$schema": "http://json-schema.org/draft-04/schema",
                "title": "Texture",
                "type": "object",
                "description": "A texture and its sampler.",
                "allOf": [ { "$ref": "glTFChildOfRootProperty.schema.json" } ],
                "properties": {
                    "sampler": {
                        "allOf": [ { "$ref": "glTFid.schema.json" } ],
                        "description": "The index of the sampler used by this texture. When undefined, a sampler with repeat wrapping and auto filtering should be used."
                    },
                    "source": {
                        "allOf": [ { "$ref": "glTFid.schema.json" } ],
                        "description": "The index of the image used by this texture. When undefined, it is expected that an extension or other mechanism will supply an alternate texture source, otherwise behavior is undefined."
                    },
                    "name": { },
                    "extensions": { },
                    "extras": { }
                },
                "gltf_webgl": "`createTexture()`, `deleteTexture()`, `bindTexture()`, `texImage2D()`, and `texParameterf()`"


             */



            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? sampler { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? source { get; set; } = null;




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
