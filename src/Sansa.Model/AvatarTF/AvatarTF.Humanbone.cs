namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張：ヒューマノイドボーン
        /// </summary>
        public class Humanbone
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// ボーン名
            /// </summary>
            public string bone { get; set; } = null;

            /// <summary>
            /// ノードNo.（ノードリストのインデックス）
            /// </summary>
            public int? node { get; set; } = null;

            /// <summary>
            /// デフォルト値を使用
            /// TODO:説明
            /// </summary>
            public bool? useDefaultValues { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
