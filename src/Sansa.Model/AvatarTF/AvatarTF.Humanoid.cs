using System.Collections.Generic;

namespace Sansa.Model
{
    public partial class AvatarTF
    {
        /// <summary>
        /// VRM拡張：ノードへのヒューマノイドボーンの割り当て
        /// </summary>
        public class Humanoid
        {
#pragma warning disable IDE1006 // 命名スタイル

            /// <summary>
            /// ヒューマノイドボーンリスト
            /// </summary>
            public List<Humanbone> humanBones { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? armStretch { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? legStretch { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? upperArmTwist { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? lowerArmTwist { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? upperLegTwist { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public double? lowerLegTwist { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public int? feetSpacing { get; set; } = null;

            /// <summary>
            /// TODO: 説明
            /// </summary>
            public bool? hasTranslationDoF { get; set; } = null;

#pragma warning restore IDE1006 // 命名スタイル
        }
    }
}
