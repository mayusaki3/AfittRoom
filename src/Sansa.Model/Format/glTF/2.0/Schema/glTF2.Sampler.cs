using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// TODO: 説明
        /// Texture sampler properties for filtering and wrapping modes.
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/sampler.schema.json
        /// "gltf_webgl": "`texParameterf()`"
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Sampler
        {
            /// <summary>
            /// TODO: 説明
            /// </summary>
            public enum MagFilter : int
            {
                /// <summary>
                /// TODO: 説明
                /// </summary>
                NEAREST = 9728,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                LINEAR = 9729
            }

            /// <summary>
            /// TODO: 説明
            /// Magnification filter.
            /// Magnification filter.  Valid values correspond to WebGL enums: `9728` (NEAREST) and `9729` (LINEAR).
            /// </summary>
            /// <remarks>
            /// "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_MAG_FILTER
            /// </remarks>
            public MagFilter? magFilter { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public enum MinFilter : int
            {
                /// <summary>
                /// TODO: 説明
                /// </summary>
                NEAREST = 9728,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                LINEAR = 9729,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                NEAREST_MIPMAP_NEAREST = 9984,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                LINEAR_MIPMAP_NEAREST = 9985,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                NEAREST_MIPMAP_LINEAR = 9986,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                LINEAR_MIPMAP_LINEAR = 9987
            }

            /// <summary>
            /// TODO: 説明
            /// Minification filter.
            /// Minification filter.  All valid values correspond to WebGL enums.
            /// </summary>
            /// <remarks>
            /// "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_MIN_FILTER"
            /// </remarks>
            public MinFilter? minFilter { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public enum Wrap : int
            {
                /// <summary>
                /// TODO: 説明
                /// </summary>
                CLAMP_TO_EDGE = 33071,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                MIRRORED_REPEAT = 33648,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                REPEAT = 10497
            }

            /// <summary>
            /// TODO: 説明
            /// s wrapping mode.
            /// S (U) wrapping mode.  All valid values correspond to WebGL enums.
            /// </summary>
            /// <remarks>
            /// default": 10497
            /// "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_WRAP_S"
            /// </remarks>
            public Wrap? wrapS { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// t wrapping mode.
            /// T (V) wrapping mode.  All valid values correspond to WebGL enums.
            /// </summary>
            /// <remarks>
            /// "default": 10497
            /// "gltf_webgl": "`texParameterf()` with pname equal to TEXTURE_WRAP_T"
            /// </remarks>
            public Wrap? wrapT { get; set; } = null;

            /// <summary>
            /// 名前
            /// TODO: 説明
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
