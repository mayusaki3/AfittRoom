using System.Collections.Generic;

namespace Sansa.Model.Format
{
    public partial class GLTF
    {
        public partial class Animation
        {
            /// <summary>
            /// アニメーションチャンネル
            /// <br/>アニメーションのサンプラーをノードのプロパティに設定します。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/animation.channel.schema.json
            /// </remarks>
            public partial class Channel
            {
#pragma warning disable IDE1006 // 命名スタイル

                /// <summary>
                /// ターゲットの値を計算するために使用される、このアニメーション内のサンプラーのインデックス
                /// <br/>例えば、ノードの移動、回転、スケール（TRS）などです。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public int? sampler { get; set; } = null;

                /// <summary>
                /// 対象となるノードとTRSのプロパティのインデックス
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public int? target { get; set; } = null;

                /// <summary>
                /// エクステンション
                /// </summary>
                public List<Extension> extensions { get; set; } = null;

                /// <summary>
                /// アプリケーション固有のデータ
                /// </summary>
                public Extras extras { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
            }
        }
    }
}
