using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// テクスチャー
        /// TODO: 説明
        /// A texture and its sampler.
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/texture.schema.json
        /// gltf_webgl": "`createTexture()`, `deleteTexture()`, `bindTexture()`, `texImage2D()`, and `texParameterf()`"
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Texture
        {
            /// <summary>
            /// TODO: 説明
            /// The index of the sampler used by this texture. When undefined, a sampler with repeat wrapping and auto filtering should be used.
            /// </summary>
            public int? sampler { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// The index of the image used by this texture. When undefined, it is expected that an extension or other mechanism will supply an alternate texture source, otherwise behavior is undefined.
            /// </summary>
            public int? source { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このテクスチャーの名前です。
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
