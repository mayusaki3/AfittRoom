using System.Collections.Generic;

namespace Sansa.Model.Format
{
    public partial class GLTF
    {
        /// <summary>
        /// アセット
        /// <br/>glTFアセットに関するメタデータ。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/asset.schema.json
        /// </remarks>
        public class Asset
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// コンテンツ作成者のクレジットを表示するのに適した著作権メッセージ
            /// </summary>
            public string copyright { get; set; } = null;

            /// <summary>
            /// このglTFモデルを生成したツール
            /// <br/>デバッグに便利です。
            /// </summary>
            public string generator { get; set; } = null;

            /// <summary>
            /// このアセットが対象とするglTFのバージョン
            /// <br/>
            /// </summary>
            /// <remarks>
            /// 形式: ^[0-9]+\\.[0-9]+$
            /// </remarks>
            public string version { get; set; } = null;

            /// <summary>
            /// このアセットが対象とする最小のglTFバージョン
            /// </summary>
            /// <remarks>
            /// 形式: ^[0-9]+\\.[0-9]+$
            /// </remarks>
            public string minVersion { get; set; } = null;

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
