using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            /// <summary>
            /// VRM拡張
            /// <br/>VRM拡張は、VRアプリケーションにおける3Dヒューマノイド
            /// アバター（およびモデル）のためのものです。
            /// </summary>
            /// <remarks>
            /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class VRM0
            {
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
                /// モデルのメタ情報
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public Meta meta { get; set; } = null;

                /// <summary>
                /// ノードへのヒューマノイドボーンの割り当て
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public Humanoid humanoid { get; set; } = null;

                /// <summary>
                /// 一人称視点の設定
                /// </summary>
                public FirstPerson firstPerson { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public BlendShape blendShapeMaster { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public SecondaryAnimation secondaryAnimation { get; set; } = null;

                /// <summary>
                /// TODO: 説明
                /// </summary>
                public List<Material> materialProperties { get; set; } = null;
            }
        }
    }
}