using System.Collections.Generic;

namespace Sansa.Model.Format
{
    public partial class GLTF
    {
        /// <summary>
        /// カメラ
        /// <br/>カメラの投影。
        /// <br/>ノードはカメラを参照して、シーン内にカメラを配置するためのトランスフォームを適用することができます。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/camera.schema.json
        /// </remarks>
        public partial class Camera
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// 正射投影マトリクスを作成するためのプロパティを持つ正射投影カメラ
            /// </summary>
            /// <remarks>
            /// 必須項目ではない
            /// </remarks>
            public OrthoGraphic orthographic { get; set; } = null;

            /// <summary>
            /// 透視投影マトリクスを作成するためのプロパティを持つ透視投影カメラ
            /// </summary>
            /// <remarks>
            /// 必須項目ではない
            /// </remarks>
            public Perspective perspective { get; set; } = null;

            /// <summary>
            /// カメラが透視投影か正射投影かを指定
            /// </summary>
            public enum @Type
            {
                perspective,

                orthographic
            }

            /// <summary>
            /// カメラが透視投影か正射投影かを指定
            /// これに基づいて、カメラの perspective または orthographic プロパティが定義されます。
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
            public List<Extension> extensions { get; set; } = null;

            /// <summary>
            /// アプリケーション固有のデータ
            /// </summary>
            public Extras extras { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
