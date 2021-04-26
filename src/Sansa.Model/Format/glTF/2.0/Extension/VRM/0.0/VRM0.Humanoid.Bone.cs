using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                public partial class Humanoid
                {
                    /// <summary>
                    /// VRM拡張：ヒューマノイドボーン
                    /// </summary>
                    /// <remarks>
                    /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.humanoid.bone.schema.json
                    /// </remarks>
                    [TypeConverter(typeof(ExpandableObjectConverter))]
                    public class Bone
                    {
                        /// <summary>
                        /// ヒューマンボーンの名前
                        /// </summary>
                        public enum BoneName
                        {
                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            hips,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftUpperLeg,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightUpperLeg,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftLowerLeg,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightLowerLeg,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftFoot,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightFoot,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            spine,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            chest,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            neck,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            head,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftShoulder,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightShoulder,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftUpperArm,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightUpperArm,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftLowerArm,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightLowerArm,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftHand,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightHand,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftToes,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightToes,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftEye,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightEye,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            jaw,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftThumbProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftThumbIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftThumbDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftIndexProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftIndexIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftIndexDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftMiddleProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftMiddleIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftMiddleDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftRingProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftRingIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftRingDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftLittleProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftLittleIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            leftLittleDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightThumbProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightThumbIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightThumbDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightIndexProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightIndexIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightIndexDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightMiddleProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightMiddleIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightMiddleDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightRingProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightRingIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightRingDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightLittleProximal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightLittleIntermediate,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            rightLittleDistal,

                            /// <summary>
                            /// TODO: 説明
                            /// </summary>
                            upperChest
                        }

                        /// <summary>
                        /// ボーン
                        /// <br/>ヒューマンボーンの名前
                        /// </summary>
                        public BoneName? bone { get; set; } = null;

                        /// <summary>
                        /// ノード
                        /// <br/>基準となるノードのインデックス
                        /// </summary>
                        public int? node { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.useDefaultValues
                        /// </summary>
                        /// <remarks>
                        /// 既定値 = false
                        /// </remarks>
                        public bool? useDefaultValues { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.min
                        /// <br/>(x, y, z)
                        /// </summary>
                        /// <remarks>
                        /// 最小 = -180.0
                        /// <br/>最大 = 0.0
                        /// </remarks>
                        public float?[] min { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.max
                        /// <br/>(x, y, z)
                        /// </summary>
                        /// <remarks>
                        /// 最小 = 0.0
                        /// <br/>最大 = 180.0
                        /// </remarks>
                        public float?[] max { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.center
                        /// <br/>(x, y, z)
                        /// </summary>
                        /// <remarks>
                        /// 既定値 = [0, 0, 0]
                        /// </remarks>
                        public float?[] center { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.axisLength
                        /// </summary>
                        public float? axisLength { get; set; } = null;
                    }
                }
            }
        }
    }
}
