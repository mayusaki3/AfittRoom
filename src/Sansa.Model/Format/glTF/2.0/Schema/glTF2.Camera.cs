using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// カメラ
        /// <br/>カメラの投影。
        /// <br/>ノードはカメラを参照して、シーン内にカメラを配置するためのトランスフォームを適用することができます。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/camera.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Camera
        {
            /// <summary>
            /// 正射投影マトリクスを作成するためのプロパティを持つ正射投影カメラ
            /// </summary>
            /// <remarks>
            /// type = orthographic の場合は必須項目
            /// </remarks>
            public OrthoGraphic orthographic { get; set; } = null;

            /// <summary>
            /// 透視投影マトリクスを作成するためのプロパティを持つ透視投影カメラ
            /// </summary>
            /// <remarks>
            /// type = perspective の場合は必須項目
            /// </remarks>
            public Perspective perspective { get; set; } = null;

            /// <summary>
            /// カメラの投影
            /// </summary>
            public enum @Type
            {
                /// <summary>
                /// 透視投影タイプ
                /// </summary>
                perspective,

                /// <summary>
                /// 正射投影
                /// </summary>
                orthographic
            }

            /// <summary>
            /// 透視投影タイプ
            /// <br/>カメラが透視投影か正射投影かを指定します。
            /// <br/>これに基づいて、カメラの perspective または orthographic プロパティが定義されます。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// </remarks>
            public Type? type { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このカメラの名前です。
            /// </summary>
            public string name { get; set; } = null;

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
