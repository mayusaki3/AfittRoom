namespace Sansa.Model
{
    /// <summary>
    /// アバター
    /// </summary>
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張
        /// <br/>VRM拡張は、VRアプリケーションにおける3Dヒューマノイド
        /// アバター（およびモデル）のためのものです。
        /// </summary>
        /// <remarks>
        /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.schema.json
        /// </remarks>
        public class VRM
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// エクスポーターバージョン
            /// vrmを作成したエクスポーターのバージョンです。
            /// </summary>
            public string exporterVersion { get; set; } = null;

            /// <summary>
            /// VRMの仕様バージョン
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// </remarks>
            public string specVersion { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// </remarks>
            public Meta meta { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// </remarks>
            public Humanoid humanoid { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public FirstPerson firstPerson { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public BlendShapeMaster blendShapeMaster { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public SecondaryAnimation secondaryAnimation { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public MaterialProperty[] materialProperties { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
