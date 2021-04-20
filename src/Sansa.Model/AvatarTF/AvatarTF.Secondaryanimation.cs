namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// TODO: 説明
        /// </summary>
        public class Secondaryanimation
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Bonegroup[] boneGroups { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Collidergroup[] colliderGroups { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
