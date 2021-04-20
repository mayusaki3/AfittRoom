namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// TODO: 説明
        /// </summary>
        public class Materialproperty
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string name { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? renderQueue { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string shader { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Floatproperties floatProperties { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Vectorproperties vectorProperties { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Textureproperties textureProperties { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Keywordmap keywordMap { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Tagmap tagMap { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
