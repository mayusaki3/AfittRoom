namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// アクセサ
        /// </summary>
        public class Accessor
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// バッファービューのインデックス
            /// 未定義の場合は、スパース オブジェクトでインデックスと値のバッファ ビューを探します。
            /// </summary>
            public int? bufferView { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? byteOffset { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string type { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? componentType { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? count { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double?[] max { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double?[] min { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public bool? normalized { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
