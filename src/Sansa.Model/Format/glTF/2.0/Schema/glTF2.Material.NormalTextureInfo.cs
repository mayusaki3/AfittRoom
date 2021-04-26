using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Material
        {
            /// <summary>
            /// マテリアルのノーマルテクスチャー情報
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/material.normalTextureInfo.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class NormalTextureInfo
            {
                /// <summary>
                /// テクスチャーのインデックス
                /// </summary>
                /// <remarks>
                /// 必須項目
                /// </remarks>
                public int? index { get; set; } = null;

                /// <summary>
                /// テクスチャの座標マッピングに使用されるテクスチャのTEXCOORD属性のセットインデックス
                /// <br/>この整数値は、mesh.primitives.attributes のキーへの参照である TEXCOORD_&lt;set index&gt; という
                /// フォーマットの文字列を構築するために使用されます。
                /// <br/>例：0の値は TEXCOORD_0 に対応します
                /// <br/>メッシュにマテリアルを適用するには、対応するテクスチャ座標属性が必要です。
                /// </summary>
                /// <remarks>
                /// 既定値 = 0
                /// <br/>最小 = 0
                /// </remarks>
                public int? texCoord { get; set; } = null;

                /// <summary>
                /// テクスチャーの各法線ベクトルに適用されるスカラーマルチプライヤー
                /// <br/>この値は式を使って法線ベクトルをスケーリングします。
                /// <br/>scaledNormal = normalize((&lt;サンプル法線テクスチャ値&gt; * 2.0 - 1.0) * vec3(&lt;法線スケール&gt;
                /// , &lt;法線スケール&gt;, 1.0))
                /// <br/>normalTexture が指定されていない場合、この値は無視されます。
                /// <br/>この値は線形です。
                /// </summary>
                /// <remarks>
                /// 既定値 = 1.0
                /// </remarks>
                public float? scale { get; set; } = null;

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
