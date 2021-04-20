namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// ノード
        /// </summary>
        public class Node
        {
            /// <summary>
            /// 子ノードNo.（ノードリストのインデックス）
            /// </summary>
            public int[] children { get; set; } = null;

            /// <summary>
            /// ノード名
            /// </summary>
            public string name { get; set; } = null;

            /// <summary>
            /// 平行移動 [x, y, z]
            /// </summary>
            public float[] translation { get; set; } = null;

            /// <summary>
            /// 回転 [x, y, z, w]
            /// </summary>
            public float[] rotation { get; set; } = null;

            /// <summary>
            /// スケール倍率 [x, y, z]
            /// </summary>
            public float[] scale { get; set; } = null;

            /// <summary>
            /// メッシュNo.（メッシュリストのインデックス）
            /// </summary>
            public int mesh { get; set; } = -1;

            /// <summary>
            /// スキンNo.（スキンリストのインデックス）
            /// </summary>
            public int skin { get; set; } = -1;
        }
    }
}
