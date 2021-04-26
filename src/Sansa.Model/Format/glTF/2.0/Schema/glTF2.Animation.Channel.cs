using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
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
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class Channel
            {
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
                public Extensions extensions { get; set; } = null;

                /// <summary>
                /// アプリケーション固有のデータ
                /// </summary>
                public Extras extras { get; set; } = null;
            }
        }
    }
}
