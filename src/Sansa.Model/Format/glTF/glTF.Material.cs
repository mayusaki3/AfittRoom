using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sansa.Model.Format
{
    public partial class glTF
    {
        /// <summary>
        /// マテリアル
        /// <br/>プリミティブの物質的な外観です。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/material.schema.json
        /// </remarks>
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
            /// TODO: 説明
            /// </summary>
            public double?[] emissiveFactor { get; set; } = null;


            /*

    "properties": {
        "emissiveFactor": {
            "type": "array",
            "items": {
                "type": "number",
                "minimum": 0.0,
                "maximum": 1.0
            },
            "minItems": 3,
            "maxItems": 3,
            "default": [ 0.0, 0.0, 0.0 ],
            "description": "The emissive color of the material.",
            "gltf_detailedDescription": "The RGB components of the emissive color of the material. These values are linear. If an emissiveTexture is specified, this value is multiplied with the texel values."
        },
        "alphaMode": {
            "default": "OPAQUE",
            "description": "The alpha rendering mode of the material.",
            "gltf_detailedDescription": "The material's alpha rendering mode enumeration specifying the interpretation of the alpha value of the main factor and texture.",
            "anyOf": [
                {
                    "enum": [ "OPAQUE" ],
                    "description": "The alpha value is ignored and the rendered output is fully opaque."
                },
                {
                    "enum": [ "MASK" ],
                    "description": "The rendered output is either fully opaque or fully transparent depending on the alpha value and the specified alpha cutoff value."
                },
                {
                    "enum": [ "BLEND" ],
                    "description": "The alpha value is used to composite the source and destination areas. The rendered output is combined with the background using the normal painting operation (i.e. the Porter and Duff over operator)."
                },
                {
                    "type": "string"
                }
            ]
        },
        "alphaCutoff": {
            "type": "number",
            "minimum": 0.0,
            "default": 0.5,
            "description": "The alpha cutoff value of the material.",
            "gltf_detailedDescription": "Specifies the cutoff threshold when in `MASK` mode. If the alpha value is greater than or equal to this value then it is rendered as fully opaque, otherwise, it is rendered as fully transparent. A value greater than 1.0 will render the entire material as fully transparent. This value is ignored for other modes."
        },
        "doubleSided": {
            "type": "boolean",
            "default": false,
            "description": "Specifies whether the material is double sided.",
            "gltf_detailedDescription": "Specifies whether the material is double sided. When this value is false, back-face culling is enabled. When this value is true, back-face culling is disabled and double sided lighting is enabled. The back-face must have its normals reversed before the lighting equation is evaluated."
        }
    },
     "dependencies" : {
        "alphaCutoff" : ["alphaMode"]
    }             

             */






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
        }
    }
}
