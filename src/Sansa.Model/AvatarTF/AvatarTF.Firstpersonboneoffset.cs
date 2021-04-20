namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張：一人時のヘッドセットの目標位置
        /// </summary>
        public class Firstpersonboneoffset
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// X座標
            /// </summary>
            public double? x { get; set; } = null;

            /// <summary>
            /// Y座標
            /// </summary>
            public double? y { get; set; } = null;

            /// <summary>
            /// Z座標
            /// </summary>
            public double? z { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
