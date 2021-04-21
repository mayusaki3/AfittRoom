namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// マテリアル PBR（物理ベースレンダリング）金属表面の粗さ
        /// PBR（Physically-Based Rendering）方法論の金属的な粗さのマテリアルモデルを定義するために使用されるパラメータ値のセットです。
        /// </summary>
        /// <remarks>
        /// https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/material.pbrMetallicRoughness.schema.json
        /// </remarks>
        public class Pbrmetallicroughness
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// ベースカラー係数
            /// <br/>素材のベースとなるカラー係数です。
            /// </summary>
            /// <remarks>
            /// 既定値 = [ 1.0, 1.0, 1.0, 1.0 ]
            /// <br/>最小 = 0.0
            /// <br/>最大 = 1.0
            /// </remarks>
            public double?[] baseColorFactor { get; set; } = null;

            /// <summary>
            /// ベースカラーテクスチャ
            /// <br/>最初の3成分（RGB）は、sRGBのトランスファー関数でエンコードされます。
            /// <br/>素材のベースカラーを指定します。
            /// <br/>第4成分（A）が存在する場合は、素材の線形アルファカバレッジを表します。
            /// <br/>それ以外の場合は、1.0のアルファを想定しています。
            /// <br/>alphaModeプロパティは、アルファがどのように解釈されるかを指定します。
            /// <br/>保存されているテクセルは、事前に乗算してはいけません。
            /// </summary>
            public TextureInfo baseColorTexture { get; set; } = null;


            /// <summary>
            /// マテリアルの金属感
            /// <br/>1.0の値は、材料が金属であることを意味します。
            /// <br/>0.0の値は素材が誘電体であることを意味します。
            /// <br/>中間の値は、汚れた金属表面など、金属と誘電体の間の混合物を意味します。
            /// <br/>この値は線形です。
            /// <br/>metallicRoughnessTextureが指定されている場合は、この値に金属のテクセル値が乗算されます。
            /// </summary>
            /// <remarks>
            /// 既定値 = 1.0
            /// <br/>最小 = 0.0
            /// <br/>最大 = 1.0,
            /// </remarks>
            public int? metallicFactor { get; set; } = null;

            /// <summary>
            /// マテリアルの粗さ（ラフネス）
            /// <br/>1.0の値は、素材が完全に粗いことを意味します。
            /// <br/>0.0の値は、素材が完全に滑らかであることを意味します。
            /// <br/>この値は線形です。
            /// <br/>metallicRoughnessTextureが指定されている場合は、この値に粗さのテクセル値が乗算されます。
            /// </summary>
            /// <remarks>
            /// 既定値 = 1.0
            /// <br/>最小 = 0.0
            /// <br/>最大 = 1.0,
            /// </remarks>
            public double? roughnessFactor { get; set; } = null;

            /// <summary>
            /// 金属的な荒々しさのあるテクスチャ
            /// <br/>メタルネス（非金属）値はBチャンネルからサンプリングされています。
            /// <br/>粗さの値は、Gチャンネルからサンプリングされます。
            /// <br/>これらの値は線形です。
            /// <br/>他のチャンネル（RまたはA）が存在する場合、メタリックラフネスの計算ではそれらは無視されます。
            /// </summary>
            public TextureInfo metallicRoughnessTexture { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
