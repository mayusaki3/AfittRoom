using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// アセット
        /// <br/>glTFアセットに関するメタデータ。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/asset.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Asset
        {
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
            public Extensions extensions { get; set; } = null;

            /// <summary>
            /// アプリケーション固有のデータ
            /// </summary>
            public Extras extras { get; set; } = null;
        }
    }
}
