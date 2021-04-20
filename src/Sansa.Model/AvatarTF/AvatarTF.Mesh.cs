namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// メッシュ
        /// </summary>
        public class Mesh
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string name { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Primitive[] primitives { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
