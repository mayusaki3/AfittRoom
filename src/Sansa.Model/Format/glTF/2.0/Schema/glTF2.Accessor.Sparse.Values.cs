using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Accessor
        {
            public partial class Sparse
            {
                /// <summary>
                /// アクセサスパース値
                /// <br/>サイズ accessor.sparse.count に accessor.sparse.indices で指定された
                /// 変位したアクセサ属性を格納するコンポーネントの数を掛けた配列です。
                /// </summary>
                /// <remarks>
                /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/accessor.sparse.values.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class Values
                {
                    /// <summary>
                    /// bufferViewのインデックス
                    /// <br/>スパースな値を持つ bufferView のインデックスです。
                    /// <br/>参照された bufferView は、ARRAY_BUFFER または ELEMENT_ARRAY_BUFFER ターゲットを持つことはできません。
                    /// </summary>
                    /// <remarks>
                    /// 必須項目
                    /// </remarks>
                    public int? bufferView { get; set; } = null;

                    /// <summary>
                    /// バイトオフセット
                    /// <br/>bufferView の開始点からの相対的なオフセットをバイト単位で指定します。
                    /// <br/>アラインメントが必要です。
                    /// </summary>
                    /// <remarks>
                    /// <br/>既定値 = 0
                    /// <br/>最小 = 0
                    /// </remarks>
                    public int? byteOffset { get; set; } = null;

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
}
