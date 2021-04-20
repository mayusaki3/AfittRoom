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
        public partial class Material
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string name { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Pbrmetallicroughness pbrMetallicRoughness { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Normaltexture normalTexture { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Emissivetexture emissiveTexture { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int[] emissiveFactor { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public bool? doubleSided { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public string alphaMode { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Extensions extensions { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
