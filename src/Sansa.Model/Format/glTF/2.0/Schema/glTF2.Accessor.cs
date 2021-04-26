using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// アクセサ
        /// <br/>型付けされたビューを bufferView に入力します。
        /// <br/>bufferView は生のバイナリデータを含みます。
        /// <br/>アクセサは、WebGLの vertexAttribPointer() がバッファ内の属性を定義するのと同様に、
        /// bufferView または bufferView のサブセットに型付けされたビューを提供します。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/accessor.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Accessor
        {
            /// <summary>
            /// bufferViewのインデックス
            /// <br/>定義されていない場合、アクセサはゼロで初期化されなければなりません。
            /// <br/>sparse プロパティや拡張機能によって、ゼロを実際の値で上書きすることができます。
            /// </summary>
            public int? bufferView { get; set; } = null;

            /// <summary>
            /// バイトオフセット
            /// <br/>bufferView の開始点からの相対的なオフセットをバイト単位で指定します。
            /// <br/>これは、コンポーネントデータタイプのサイズの倍数でなければなりません。
            /// </summary>
            /// <remarks>
            /// 依存関係: bufferView
            /// <br/>既定値 = 0
            /// <br/>最小 = 0
            /// <br/>WebGLの場合: vertexAttribPointer() のオフセットパラメータ
            /// </remarks>
            public int? byteOffset { get; set; } = null;

            /// <summary>
            /// コンポーネントのデータタイプ
            /// </summary>
            public enum ComponentType : int
            {
                BYTE = 5120,

                UNSIGNED_BYTE = 5121,

                SHORT = 5122,

                UNSIGNED_SHORT = 5123,

                UNSIGNED_INT = 5125,

                FLOAT = 5126
            }

            /// <summary>
            /// コンポーネントのデータタイプ
            /// <br/>属性内のコンポーネントのデータタイプです。
            /// <br/>すべての有効な値は WebGL enum に対応しています。
            /// <br/>対応する型付き配列は、
            /// それぞれ Int8Array, Uint8Array, Int16Array, Uint16Array, Uint32Array および Float32Array です。
            /// <br/>5125 (UNSIGNED_INT) は、アクセサがインデックスを含む場合、つまり、
            /// アクセサが primitive.indices によってのみ参照される場合にのみ許可されます。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// <br/>WebGLの場合: vertexAttribPointer() タイプのパラメータ
            /// </remarks>
            public ComponentType? componentType { get; set; } = null;

            /// <summary>
            /// 正規化
            /// <br/>整数データの値をアクセスする際に、[0, 1](符号なしタイプの場合)
            /// または[-1, 1](符号ありタイプの場合)に正規化する(true)か、
            /// 直接変換する(false)かを指定します。
            /// <br/>このプロパティは、頂点属性やアニメーションの出力データを含むアクセサにのみ定義されています。
            /// </summary>
            /// <remarks>
            /// WebGLの場合: vertexAttribPointer() 正規化パラメータ
            /// </remarks>
            public bool? normalized { get; set; } = null;

            /// <summary>
            /// 属性の数
            /// <br/>このアクセサが参照する属性の数。
            /// <br/>バイト数やコンポーネント数とは異なります。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// </remarks>
            public int? count { get; set; } = null;

            /// <summary>
            /// 属性のタイプ
            /// </summary>
            public enum AttributeType : int
            {
                SCALAR,

                VEC2,

                VEC3,

                VEC4,

                MAT2,

                MAT3,

                MAT4,

                @string
            }

            /// <summary>
            /// 属性のタイプ
            /// <br/>属性がスカラー、ベクトル、マトリックスのいずれであるかを指定します。
            /// </summary>
            /// <remarks>
            /// 必須項目
            /// </remarks>
            public AttributeType? type { get; set; } = null;

            /// <summary>
            /// 各コンポーネントの最大値リスト
            /// <br/>リストの要素は、アクセサの componentType と同じデータ型として扱われなければなりません。
            /// <br/>min と max のリストはどちらも同じ長さです。
            /// <br/>この長さは type プロパティの値によって決定され、1、2、3、4、9、16 のいずれかになります。
            /// <br/>アクセサがスパースな場合、このプロパティには、スパース置換が適用された
            /// アクセサデータの最大値が格納されていなければなりません。
            /// </summary>
            /// <remarks>
            /// 指定する場合、リストの要素は 1 から 16 個の範囲で定義します。
            /// </remarks>
            public List<float> max { get; set; } = null;

            /// <summary>
            /// 各コンポーネントの最小値リスト
            /// <br/>リストの要素は、アクセサの componentType と同じデータ型として扱われなければなりません。
            /// <br/>min と max の配列はどちらも同じ長さです。
            /// <br/>この長さは type プロパティの値によって決定され、1、2、3、4、9、16 のいずれかになります。
            /// <br/>アクセサがスパースな場合、このプロパティには、スパース置換が適用された
            /// アクセサデータの最小値が含まれていなければなりません。
            /// </summary>
            /// <remarks>
            /// 指定する場合、リストの要素は 1 から 16 個の範囲で定義します。
            /// </remarks>
            public List<float> min { get; set; } = null;

            /// <summary>
            /// スパース
            /// <br/>初期化値から逸脱した属性をスパースに保存します。
            /// </summary>
            public Sparse sparse { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このアクセサの名前です。
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
