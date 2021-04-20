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
        /// TODO: 説明
        /// </summary>
        public class Pbrmetallicroughness
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public Basecolortexture baseColorTexture { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int[] baseColorFactor { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? metallicFactor { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? roughnessFactor { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
