using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Camera
        {
            /// <summary>
            /// カメラの正射投影
            /// <br/>正射投影マトリクスを作成するためのプロパティを持つ正射投影カメラです。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/camera.orthographic.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class OrthoGraphic
            {
                /// <summary>
                /// ビューの水平方向の倍率
                /// <br/>浮動小数点で指定します。
                /// <br/>ゼロであってはなりません。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public float? xmag { get; set; } = null;

                /// <summary>
                /// ビューの垂直方向の倍率
                /// <br/>浮動小数点で指定します。
                /// <br/>ゼロであってはなりません。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public float? ymag { get; set; } = null;

                /// <summary>
                /// 遠くのクリッピング・プレーンまでの距離
                /// <br/>浮動小数点で指定します。
                /// <br/>zfar は znear よりも大きくなければなりません。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// <br/>最小 = 0.0
                /// <br/>最小値を含まない
                /// </remarks>
                public float? zfar { get; set; } = null;

                /// <summary>
                /// 近接クリッピング・プレーンまでの距離
                /// <br/>浮動小数点で指定します。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// <br/>最小 = 0.0
                /// </remarks>
                public float? znear { get; set; } = null;

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
