using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// バッファビュー
        /// 一般的にバッファのサブセットを表すバッファ内のビューを表します。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/bufferView.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class BufferView
        {
            /// <summary>
            /// バッファのインデックス
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>最小 = 0
            /// </remarks>
            public int? buffer { get; set; } = null;

            /// <summary>
            /// バッファへのオフセット
            /// <br/>バイト単位で指定します。
            /// </summary>
            /// <remarks>
            /// 既定値 = 0
            /// <br/>最小 = 0
            /// </remarks>
            public int? byteOffset { get; set; } = null;

            /// <summary>
            /// bufferViewの長さ
            /// <br/>バイト単位で指定します。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>最小 = 1
            /// </remarks>
            public int? byteLength { get; set; } = null;

            /// <summary>
            /// ストライドをバイト単位で指定
            /// <br/>頂点のアトリビュート間のストライドをバイト単位で指定します。
            /// <br/>これが定義されていない場合、データは密に詰め込まれます。
            /// <br/>複数のアクセサが同じ bufferView を使用する場合は、このフィールドを定義する必要があります。
            /// </summary>
            /// <remarks>
            /// 最小 = 4
            /// <br/>最大 = 252
            /// <br/>4の倍数です。
            /// <br/>WebGLの場合: vertexAttribPointer() のstrideパラメータ
            /// </remarks>
            public int? byteStride { get; set; } = null;

            /// <summary>
            /// GPUバッファがバインドされるべきターゲット
            /// </summary>
             public enum Target : int
            {
                /// <summary>
                /// TODO: 説明
                /// </summary>
                ARRAY_BUFFER = 34962,

                /// <summary>
                /// TODO: 説明
                /// </summary>
                ELEMENT_ARRAY_BUFFER = 34963
            }

            /// <summary>
            /// GPUバッファがバインドされるべきターゲット
            /// </summary>
            /// <remarks>
            /// WebGLの場合: bindBuffer()
            /// </remarks>
            public Target? target { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このバッファビューの名前です。
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
