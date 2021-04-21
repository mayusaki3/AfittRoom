namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// アセット
        /// <br/>glTFアセットに関するメタデータ。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/asset.schema.json
        /// </remarks>
        public class Asset
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string generator { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string version { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
