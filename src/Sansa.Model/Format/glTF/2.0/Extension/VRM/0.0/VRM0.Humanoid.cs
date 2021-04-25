using System.Collections.Generic;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                /// <summary>
                /// VRM拡張：ノードへのヒューマノイドボーンの割り当て
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.humanoid.schema.json
                /// </remarks>
                public partial class Humanoid
                {
                    /// <summary>
                    /// ヒューマノイドボーンリスト
                    /// </summary>
                    public List<Bone> humanBones { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.armStretch
                    /// </summary>
                    public double? armStretch { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.legStretch
                    /// </summary>
                    public double? legStretch { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.upperArmTwist
                    /// </summary>
                    public double? upperArmTwist { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.lowerArmTwist
                    /// </summary>
                    public double? lowerArmTwist { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.upperLegTwist
                    /// </summary>
                    public double? upperLegTwist { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.lowerLegTwist
                    /// </summary>
                    public double? lowerLegTwist { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.feetSpacing
                    /// </summary>
                    public int? feetSpacing { get; set; } = null;

                    /// <summary>
                    /// Unity の HumanDescription.hasTranslationDoF
                    /// </summary>
                    public bool? hasTranslationDoF { get; set; } = null;
                }
            }
        }
    }
}
