namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// バッファ
        /// <br/>バイナリのジオメトリ、アニメーション、スキンを指します。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/buffer.schema.json
        /// </remarks>
        public class Buffer
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// バッファのURI
            /// <br/>相対パスは、.gltfファイルからの相対パスです。
            /// <br/>外部ファイルを参照する代わりに、uriはdata-uriにすることもできます。
            /// </summary>
            public string uri { get; set; } = null;

            /// <summary>
            /// バッファの長さ
            /// <br/>byte単位で指定します。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>最小 = 1
            /// </remarks>
            public int? byteLength { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
