namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// TODO: 説明
        /// </summary>
        public class Bonegroup
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string comment { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? stiffiness { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? gravityPower { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Gravitydir gravityDir { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? dragForce { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? center { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? hitRadius { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int?[] bones { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int?[] colliderGroups { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
