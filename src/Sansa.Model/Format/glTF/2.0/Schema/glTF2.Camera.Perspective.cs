using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Camera
        {
            /// <summary>
            /// カメラの透視投影
            /// <br/>透視投影マトリクスを作成するためのプロパティを持つ透視投影カメラです。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/camera.perspective.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class Perspective
            {
                /// <summary>
                /// 視野のアスペクト比
                /// <br/>浮動小数点で指定します。
                /// <br/>これが未定義の場合、キャンバスのアスペクト比が使用されます。
                /// </summary>
                /// <remarks>
                /// <br/>最小 = 0.0
                /// <br/>最小値を含まない
                /// </remarks>
                public float? aspectRatio { get; set; } = null;

                /// <summary>
                /// ラジアン単位の視野角
                /// <br/>浮動小数点で指定します。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// <br/>最小 = 0.0
                /// <br/>最小値を含まない
                /// </remarks>
                public float? yfov { get; set; } = null;

                /// <summary>
                /// 遠くのクリッピング・プレーンまでの距離
                /// <br/>浮動小数点で指定します。
                /// <br/>定義された場合、zfar は znear よりも大きくなければなりません。
                /// <br/>zfar が未定義の場合、ランタイムは無限の投影行列を使用しなければなりません。
                /// </summary>
                /// <remarks>
                /// 最小 = 0.0
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
                /// <br/>最小値を含まない
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
