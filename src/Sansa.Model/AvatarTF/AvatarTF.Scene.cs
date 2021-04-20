namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// シーン
        /// </summary>
        public class Scene
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// ノードリスト（ノードリストのインデックス）
            /// </summary>
            public int?[] nodes { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
