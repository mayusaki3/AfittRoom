using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Material
        {
            public partial class PbrMetallicRoughness
            {
                /// <summary>
                /// テクスチャ情報
                /// <br/>テクスチャへの参照です。
                /// </summary>
                /// <remarks>
                /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/textureInfo.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class BaseColorTextureInfo
                {

                    /// <summary>
                    /// エクステンション
                    /// </summary>
                    public Extensions extensions { get; set; } = null;

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
                    /// <br/>既定値 = 0
                    /// <br/>最小 = 0
                    /// </remarks>
                    public int? texCoord { get; set; } = null;

                    /// <summary>
                    /// アプリケーション固有のデータ
                    /// </summary>
                    public Extras extras { get; set; } = null;
                }
            }
        }
    }
}
