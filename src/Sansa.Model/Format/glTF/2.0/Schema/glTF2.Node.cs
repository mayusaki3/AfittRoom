using System.Collections.Generic;
using System.ComponentModel;
using static Sansa.Model.Format.glTF2.Extension;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// ノード
        /// <br/>ノード階層内のノードです。 
        /// <br/>ノードが skin を含む場合、すべての mesh.primitives は JOINTS_0 と WEIGHTS_0 属性を含まなければなりません。
        /// <br/>ノードは matrix または translation/rotation/scale (TRS) プロパティのいずれかの組み合わせを持つことができます。
        /// <br/>TRS プロパティは行列に変換され、変換行列を構成するために T * R * S の順序で後乗算されます。
        /// <br/>最初にスケールが頂点に適用され、次に回転、そして平行移動が行われます。
        /// <br/>ノードがアニメーションのターゲットになっている場合（animation.channel.targetで参照されている場合）、
        /// TRSプロパティのみが存在する可能性があり、matrix は存在しません。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/node.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Node
        {

            /// <summary>
            /// カメラ
            /// <br/>このノードが参照するカメラのインデックスです。
            /// </summary>
            public int? camera { get; set; } = null;

            /// <summary>
            /// 子ノード
            /// <br/>このノードの子のインデックスです。
            /// </summary>
            /// <remarks>
            /// ユニークアイテム
            /// <br/>指定する場合、最低１つ以上定義します。
            /// </remarks>
            public int?[] children { get; set; } = null;

            /// <summary>
            /// スキン
            /// <br/>このノードが参照するスキンのインデックスです。
            /// <br/>シーン内のノードからスキンが参照される場合、
            /// スキンが使用するすべてのジョイントは同じシーンに属していなければなりません。
            /// </summary>
            /// <remarks>
            /// 依存関係: mesh
            /// </remarks>
            public int? skin { get; set; } = null;

            /// <summary>
            /// マトリックス
            /// <br/>4x4の浮動小数点型変換行列で、列の長さ順に格納します．
            /// </summary>
            /// <remarks>
            /// 既定値 = [ 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0 ]
            /// <br/>WebGLの場合: uniformMatrix4fv() では、トランスポーズパラメータを false に設定しています。
            /// </remarks>
            public float?[] matrix { get;set;} = null;

            /// <summary>
            /// メッシュ
            /// <br/>このノードのメッシュのインデックスです。
            /// </summary>
            public int? mesh { get; set; } = null;

            /// <summary>
            /// 回転
            /// <br/>(x, y, z, w)の順序でノードの単位クォータニオン回転を表します。
            /// </summary>
            /// <remarks>
            /// 既定値 = [ 0.0, 0.0, 0.0, 1.0 ]
            /// <br/>最小 = -1.0
            /// <br/>最大 =  1.0
            /// </remarks>
            public float?[] rotation { get; set; } = null;

            /// <summary>
            /// スケール
            /// <br/>ノードの非一様なスケールで、x、y、z軸のスケーリングファクターとして与えられる。
            /// </summary>
            /// <remarks>
            /// 既定値 = [ 1.0, 1.0, 1.0 ]
            /// </remarks>
            public float?[] scale { get; set; } = null;

            /// <summary>
            /// 移動
            /// <br/>ノードのX、Y、Z軸方向の移動量です。
            /// </summary>
            /// <remarks>
            /// 既定値 = [ 0.0, 0.0, 0.0 ]
            /// </remarks>
            public float?[] translation { get; set; } = null;

            /// <summary>
            /// ウェイト
            /// <br/>インスタンス化されたモーフターゲットのウェイトです。
            /// 要素の数は、使用するメッシュの Morph Target の数と一致しなければなりません。
            /// </summary>
            /// <remarks>
            /// 依存関係: mesh
            /// </remarks>
            public List<float> weights { get; set; } = null;

            /// <summary>
            /// 名前
            /// <br/>このノードの名前です。
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
