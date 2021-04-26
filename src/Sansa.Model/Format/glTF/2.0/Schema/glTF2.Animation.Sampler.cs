using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Animation
        {
            /// <summary>
            /// アニメーションサンプラー
            /// <br/>入出力アクセサと補間アルゴリズムを組み合わせて、キーフレームのグラフを定義します。
            /// （ターゲットは定義しません）
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/animation.sampler.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class Sampler
            {
                /// <summary>
                /// 入力
                /// <br/>キーフレームの入力値を含むアクセサのインデックスです。
                /// <br/>例：時間
                /// <br/>このアクセサはコンポーネントタイプが FLOAT でなければなりません。
                /// <br/>値は時間を秒単位で表し、time[0] >= 0.0となり、厳密には time[n + 1] > time[n] のように増加します。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// <br/>最小 = 0
                /// </remarks>
                public int? input { get; set; } = null;

                /// <summary>
                /// 補間アルゴリズム
                /// </summary>
                public enum Interpolation
                {
                    /// <summary>
                    /// アニメーションの値は、キーフレーム間で線形補間されます。
                    /// <br/>回転を対象とする場合は、球形線形補間（slerp）を使用してクォータニオンを補間する必要があります。
                    /// <br/>出力される要素の数は、入力要素の数と等しくなければなりません。
                    /// </summary>
                    LINEAR,

                    /// <summary>
                    /// アニメーションの値は、最初のキーフレームの出力に対して、次のキーフレームまで一定に保たれます。
                    /// <br/>出力要素の数は、入力要素の数と等しくなければなりません。
                    /// </summary>
                    STEP,

                    /// <summary>
                    /// アニメーションの補間は、指定した接線を持つ三次スプラインを用いて計算されます。
                    /// <br/>出力要素の数は、入力要素の数の3倍でなければなりません。
                    /// <br/>各入力要素に対して、出力にはインタンジェント、スプラインの頂点、アウトタンジェントの
                    /// 3つの要素が格納されます。
                    /// <br/>この補間を使用する際には、少なくとも2つのキーフレームが必要です。
                    /// </summary>
                    CUBICSPLINE
                }

                /// <summary>
                /// 補間アルゴリズム
                /// </summary>
                /// <remarks>
                /// 既定値 = LINEAR
                /// </remarks>
                public Interpolation? interpolation { get; set; } = null;

                /// <summary>
                /// 出力
                /// <br/>キーフレームの出力値を含むアクセサのインデックスです。
                /// <br/>ターゲッティングトランスレーションまたはスケールパスをターゲットにする場合、
                /// 出力値の accessor.componentType は FLOAT でなければなりません。
                /// <br/>回転やモーフのウェイトをターゲットにする場合、
                /// 出力値の accessor.componentType は FLOAT または正規化された整数でなければなりません。
                /// <br/>ウェイトの場合、各出力要素はモーフターゲットの数に等しいカウントを持つ SCALAR 値を格納します。
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// <br/>最小 = 0
                /// </remarks>
                public int? output { get; set; } = null;

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
