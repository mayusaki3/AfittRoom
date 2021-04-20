namespace Sansa.Model
{
    /// <summary>
    /// アバター
    /// </summary>
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// </summary>
        public class VRM
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// エクスポーターバージョン
            /// </summary>
            public string exporterVersion { get; set; } = null;

            /// <summary>
            /// VRMバージョン
            /// </summary>
            public string specVersion { get; set; } = null;

            /// <summary>
            /// モデル情報
            /// </summary>
            public Meta meta { get; set; } = null;

            /// <summary>
            /// ノードへのヒューマノイドボーンの割り当て
            /// </summary>
            public Humanoid humanoid { get; set; } = null;

            /// <summary>
            /// 一人称設定
            /// </summary>
            public Firstperson firstPerson { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Blendshapemaster blendShapeMaster { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Secondaryanimation secondaryAnimation { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Materialproperty[] materialProperties { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
