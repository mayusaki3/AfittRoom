namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// TODO: 説明
        /// </summary>
        public class Blendshapegroup
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string name { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string presetName { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public bool? isBinary { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Bind[] binds { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public object[] materialValues { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
