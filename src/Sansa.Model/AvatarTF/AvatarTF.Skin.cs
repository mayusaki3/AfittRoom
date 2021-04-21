namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// スキン
        /// </summary>
        public class Skin
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? inverseBindMatrices { get; set; } = null;

            /// <summary>
            /// ジョイントリスト（ノードリストのインデックス）
            /// </summary>
            public int?[] joints { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? skeleton { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
