namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// プリミティブ
        /// </summary>
        public class Primitive
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? mode { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? indices { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Attributes attributes { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? material { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Target[] targets { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Extras extras { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
