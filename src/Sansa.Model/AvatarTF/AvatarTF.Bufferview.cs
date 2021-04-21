namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// バッファービュー
        /// 一般的にバッファのサブセットを表すバッファ内のビューを表します。
        /// </summary>
        public class Bufferview
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// バッファのインデックス
            /// </summary>
            public int? buffer { get; set; } = null;

            /// <summary>
            /// バッファへのオフセット（byte単位）
            /// </summary>
            public int? byteOffset { get; set; } = null;

            /// <summary>
            /// bufferViewの長さ（byte単位）
            /// </summary>
            public int? byteLength { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? target { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
