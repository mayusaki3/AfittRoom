using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// マテリアル
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/material.schema.json
        /// </remarks>
        public partial class Material
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// マテリアル PBR（物理ベースレンダリング）金属表面の粗さ
            /// <br/>Physically-Based Rendering (PBR)方法論の金属表面の粗さマテリアルモデルを定義するために使用されるパラメータ値のセットです。
            /// <br/>指定されない場合は、pbrMetallicRoughnessのすべてのデフォルト値が適用されます。
            /// </summary>
            public Pbrmetallicroughness pbrMetallicRoughness { get; set; } = null;

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
            public Normaltexture normalTexture { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public OcclusionTexture occlusionTexture { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Emissivetexture emissiveTexture { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double?[] emissiveFactor { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string alphaMode { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double?[] alphaCutoff { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public bool? doubleSided { get; set; } = null;

 
            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Extensions extensions { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
