namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// TODO: 説明
        /// </summary>
        public class Collidergroup
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? node { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Collider[] colliders { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
