using Sansa.Model.FormatHelper;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// イメージ
        /// <br/>テクスチャの作成に使用される画像データです。
        /// <br/>イメージは URI または bufferView インデックスで参照できます。
        /// <br/>後者の場合は mimeType が必要です。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/image.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Image
        {
            /// <summary>
            /// イメージのURI
            /// <br/>相対パスは、.gltfファイルからの相対パスです。
            /// <br/>外部ファイルを参照する代わりに、uri を data-uri にすることもできます。
            /// <br/>イメージのフォーマットは、jpg または png でなければなりません。
            /// </summary>
            /// <remarks>
            /// uri または bufferView のいずれか１つが必須項目
            /// </remarks>
            public string uri { get; set; } = null;

            /// <summary>
            /// イメージのMIMEタイプ
            /// </summary>
            public enum MimeType
            {
                [Enum(Value = "image/jpeg")]
                image_jpeg,

                [Enum(Value = "image/png")]
                image_png
            }

            /// <summary>
            /// イメージのMIMEタイプ
            /// <br/>bufferView が定義されている場合は必須です。
            /// </summary>
            public MimeType? mimeType { get; set; } = null;

            /// <summary>
            /// bufferView のインデックス
            /// <br/>イメージを含む bufferView のインデックスです。
            /// <br/>イメージの uri プロパティの代わりにこれを使用します。
            /// </summary>
            /// <remarks>
            /// 依存関係: mimeType
            /// uri または bufferView のいずれか１つが必須項目
            /// </remarks>
            public int? bufferView { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このイメージの名前です。
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
