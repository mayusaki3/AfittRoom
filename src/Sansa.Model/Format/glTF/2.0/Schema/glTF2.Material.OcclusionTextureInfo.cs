using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Material
        {
            /// <summary>
            /// マテリアルのオクルージョンテクスチャ情報
            /// </summary>
            /// <remarks>
            /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/material.occlusionTextureInfo.schema.json
            /// </remarks>
            [TypeConverter(typeof(ExpandableObjectConverter))]
            public partial class OcclusionTextureInfo
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
                /// オクルージョンの適用量をコントロールするスカラー倍数
                /// <br/>0.0 の値はオクルージョンがないことを意味します。
                /// <br/>1.0 の値は完全なオクルージョンを意味します。
                /// <br/>この値は次の式で得られる色に影響します。
                /// <br/>occludedColor = lerp(color, color * &lt;sampled occlusion texture value&gt;
                /// , &lt;occlusion strength&gt;)
                /// <br/>対応するテクスチャが指定されていない場合、この値は無視されます。
                /// <br/>この値は線形です。
                /// </summary>
                /// <remarks>
                /// 既定値 = 1.0
                /// <br/>最小 = 0.0
                /// <br/>最大 = 1.0
                /// </remarks>
                public float? strength { get; set; } = null;

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
