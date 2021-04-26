using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        /// <summary>
        /// マテリアル
        /// <br/>プリミティブの物質的な外観です。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/material.schema.json
        /// </remarks>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public partial class Material
        {
            /// <summary>
            /// 名前
            /// <br/>このマテリアルの名前です。
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

            /// <summary>
            /// マテリアル PBR（物理ベースレンダリング）金属表面の粗さ
            /// <br/>Physically-Based Rendering (PBR)方法論の金属表面の粗さマテリアルモデルを
            /// 定義するために使用されるパラメータ値のセットです。
            /// <br/>指定されない場合は、pbrMetallicRoughnessのすべてのデフォルト値が適用されます。
            /// </summary>
            public PbrMetallicRoughness pbrMetallicRoughness { get; set; } = null;

            /// <summary>
            /// 法線マップのテクスチャ
            /// <br/>タンジェント空間の法線マップです。
            /// <br/>テクスチャには、線形空間のRGB成分が含まれています。
            /// <br/>各テクセルは、タンジェント空間における法線ベクトルのXYZ成分を表します。
            /// <br/>赤 [  0 ～ 255] は X [-1    ～ 1] に対応します。
            /// <br/>緑 [  0 ～ 255] は Y [-1    ～ 1] に対応します。
            /// <br/>青 [128 ～ 255）は Z [1/255 ～ 1]に対応します。
            /// <br/>法線ベクトルは、「+X」が右、「+Y」が上を指します。
            /// <br/>+Z は見る人の方向を指します。
            /// <br/>GLSLでは、このベクトルは次のように展開されます。
            /// <br/>vec3 normalVector = tex2D(&lt;sampled normal map texture value&gt;, texCoord) * 2 - 1 
            /// <br/>クライアントの実装では、照明方程式で使用する前に、法線ベクトルを正規化する必要があります。
            /// </summary>
            public NormalTextureInfo normalTexture { get; set; } = null;

            /// <summary>
            /// オクルージョンマップのテクスチャ
            /// <br/>オクルージョンの値は、Rチャンネルからサンプリングされます。
            /// <br/>高い値は完全な間接照明を受けるべきエリアを示し、低い値は間接照明がないことを示します。
            /// <br/>これらの値は線形です。
            /// <br/>他のチャンネルが存在する場合（GBA）、オクルージョンの計算では無視されます。
            /// </summary>
            public OcclusionTextureInfo occlusionTexture { get; set; } = null;

            /// <summary>
            /// エミッシヴマップのテクスチャ
            /// <br/>エミッシブマップは、マテリアルが放出する光の色と強度を制御します。
            /// <br/>このテクスチャには、sRGBトランスファー関数でエンコードされたRGB成分が含まれています。
            /// <br/>第4成分（A）が存在する場合は無視されます。
            /// </summary>
            public TextureInfo emissiveTexture { get; set; } = null;

            /// <summary>
            /// マテリアルのエミッシヴ色
            /// <br/>マテリアルの発光色のRGB成分です。
            /// <br/>これらの値は線形です。
            /// <br/>emissiveTexture が指定されている場合は、この値にテクセル値が乗算されます。
            /// </summary>
            /// <remarks>
            /// <br/>既定値 = [ 0.0, 0.0, 0.0 ]
            /// <br/>最小 = 0.0
            /// <br/>最大 = 1.0
            /// </remarks>
            public float?[] emissiveFactor { get; set; } = null;

            /// <summary>
            /// マテリアルのアルファレンダリングモード
            /// </summary>
            public enum AlphaMode
            {
                /// <summary>
                /// ルファ値は無視され、レンダリングされた出力は完全に不透明になります。
                /// </summary>
                OPAQUE,

                /// <summary>
                /// レンダリングされた出力は、アルファ値と指定されたアルファカットオフ値に応じて、
                /// 完全不透明または完全透明になります。
                /// </summary>
                MASK,

                /// <summary>
                /// アルファ値は、ソースエリアとデスティネーションエリアの合成に使用されます。
                /// <br/>レンダリングされた出力は、通常のペイント操作（PorterやDuff over演算子など）で
                /// 背景と合成されます。
                /// </summary>
                BLEND
            }

            /// <summary>
            /// マテリアルのアルファレンダリングモード
            /// <br/>マテリアルのアルファ・レンダリング・モード列挙値で、
            /// メイン・ファクターとテクスチャのアルファ値の解釈を指定します。
            /// </summary>
            /// <remarks>
            /// 既定値 = OPAQUE
            /// </remarks>
            public AlphaMode? alphaMode { get; set; } = null;

            /// <summary>
            /// マテリアルのアルファ・カットオフ値
            /// <br/>MASK`モードでのカットオフ閾値を指定します。
            /// <br/>アルファ値がこの値以上の場合は完全な不透明としてレンダリングされ、
            /// そうでない場合は完全な透明としてレンダリングされます。
            /// <br/>1.0 より大きい値を設定すると、マテリアル全体が完全に透明になります。
            /// <br/>この値は他のモードでは無視されます。
            /// </summary>
            /// <remarks>
            /// 依存関係: alphaMode
            /// <br/>既定値 = 0.5
            /// <br/>最小 = 0.0
            /// </remarks>
            public float? alphaCutoff { get; set; } = null;

            /// <summary>
            /// マテリアルが両面であるかどうかを指定
            /// <br/>この値が false の場合、バックフェイスカリングが有効になります。
            /// <br/>この値が true の場合、バックフェイスカリングは無効になり、ダブルサイドライティングが有効になります。
            /// <br/>照明方程式が評価される前に、裏表の法線が反転されている必要があります。
            /// </summary>
            /// <remarks>
            /// 既定値 = false
            /// </remarks>
            public bool? doubleSided { get; set; } = null;
        }
    }
}
