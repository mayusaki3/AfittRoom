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
                    public class Bone
                    {
                        /// <summary>
                        /// ヒューマンボーンの名前
                        /// </summary>
                        public enum BoneName
                        {
                            hips,
                            leftUpperLeg,
                            rightUpperLeg,
                            leftLowerLeg,
                            rightLowerLeg,
                            leftFoot,
                            rightFoot,
                            spine,
                            chest,
                            neck,
                            head,
                            leftShoulder,
                            rightShoulder,
                            leftUpperArm,
                            rightUpperArm,
                            leftLowerArm,
                            rightLowerArm,
                            leftHand,
                            rightHand,
                            leftToes,
                            rightToes,
                            leftEye,
                            rightEye,
                            jaw,
                            leftThumbProximal,
                            leftThumbIntermediate,
                            leftThumbDistal,
                            leftIndexProximal,
                            leftIndexIntermediate,
                            leftIndexDistal,
                            leftMiddleProximal,
                            leftMiddleIntermediate,
                            leftMiddleDistal,
                            leftRingProximal,
                            leftRingIntermediate,
                            leftRingDistal,
                            leftLittleProximal,
                            leftLittleIntermediate,
                            leftLittleDistal,
                            rightThumbProximal,
                            rightThumbIntermediate,
                            rightThumbDistal,
                            rightIndexProximal,
                            rightIndexIntermediate,
                            rightIndexDistal,
                            rightMiddleProximal,
                            rightMiddleIntermediate,
                            rightMiddleDistal,
                            rightRingProximal,
                            rightRingIntermediate,
                            rightRingDistal,
                            rightLittleProximal,
                            rightLittleIntermediate,
                            rightLittleDistal,
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
                        public double?[] min { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.max
                        /// <br/>(x, y, z)
                        /// </summary>
                        /// <remarks>
                        /// 最小 = 0.0
                        /// <br/>最大 = 180.0
                        /// </remarks>
                        public double?[] max { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.center
                        /// <br/>(x, y, z)
                        /// </summary>
                        /// <remarks>
                        /// 既定値 = [0, 0, 0]
                        /// </remarks>
                        public double?[] center { get; set; } = null;

                        /// <summary>
                        /// Unity の HumanLimit.axisLength
                        /// </summary>
                        public double? axisLength { get; set; } = null;
                    }
                }
            }
        }
    }
}
