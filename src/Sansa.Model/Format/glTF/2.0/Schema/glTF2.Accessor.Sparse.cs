using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Accessor
        {
            /// <summary>
            /// アクセサスパース
            /// <br/>初期化値から逸脱した属性をスパースに保存します。
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/accessor.sparse.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class Sparse
            {
                /// <summary>
                /// スパースリストに格納されているエントリ数
                /// <br/>このアクセサが参照する属性の数。
                /// <br/>このスパースアクセサでエンコードされた属性の数です。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public int? count { get; set; } = null;

                /// <summary>
                /// インデックスのリスト
                /// <br/>サイズ count のインデックスリストで、初期化値から逸脱したアクセサ属性を指します。
                /// <br/>インデックスは厳密に増加しなければなりません。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public List<string> indices { get; set; } = null;

                /// <summary>
                /// 値のリスト
                /// <br/>サイズ count にコンポーネントの数を掛けたリストで、indices が指す置換されたアクセサの属性を格納します。
                /// <br/>置換された値は、ベースとなるアクセサと同じ componentType とコンポーネントの数を持たなければなりません。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public List<Values> values { get; set; } = null;

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
