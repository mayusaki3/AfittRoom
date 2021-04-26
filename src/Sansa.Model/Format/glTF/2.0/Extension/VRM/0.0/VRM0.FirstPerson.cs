using System.Collections.Generic;
using System.ComponentModel;

namespace Sansa.Model.Format
{
    public partial class glTF2
    {
        public partial class Extension
        {
            public partial class VRM0
            {
                /// 
                ///<summary>
                /// VRM拡張：一人称視点の設定
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.firstperson.schema.json
                /// </remarks>
                [TypeConverter(typeof(ExpandableObjectConverter))]
                public partial class FirstPerson
                {
                    /// <summary>
                    /// 一人称視点でレンダリングをオフにすべきボーン
                    /// <br/>通常はHeadが指定されます。
                    /// </summary>
                    public int? firstPersonBone { get; set; } = null;

                    /// <summary>
                    /// 一人時のヘッドセットの目標位置
                    /// 一人称視点でのVRヘッドセットの目標位置です。頭の骨からVRヘッドセットまでのオフセットが付加されていることが前提です。
                    /// </summary>
                    public Vector3 firstPersonBoneOffset { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// 各メッシュに対して一人称時とそれ以外で表示・非表示を切り替えることができます。 
                    /// </summary>
                    public List<MeshAnnotation> meshAnnotations { get; set; } = null;

                    /// <summary>
                    /// アイコントローラモード
                    /// </summary>
                    public enum LookAtTypeName
                    {
                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        Bone,

                        /// <summary>
                        /// TODO: 説明
                        /// </summary>
                        BlendShape
                    }

                    /// <summary>
                    /// 目線タイプ
                    /// 設定値：Bone       : ボーンにより目線を操作
                    ///         BlendShape : BlendShapeにより目線を操作（BlendShapePreset.LookUp, LookDown, LookLeft, LookRightを使用）
                    /// </summary>
                    public LookAtTypeName? lookAtTypeName { get; set; } = null;

                    /// <summary>
                    /// 頭と目標物の角度差を目ボーンに適用する場合の角度を調整
                    /// TODO: 説明
                    /// </summary>
                    public DegreeMap lookAtHorizontalInner { get; set; } = null;

                    /// <summary>
                    /// 頭と目標物の角度差を目ボーンに適用する場合の角度を調整
                    /// TODO: 説明
                    /// </summary>
                    public DegreeMap lookAtHorizontalOuter { get; set; } = null;

                    /// <summary>
                    /// 頭と目標物の角度差を目ボーンに適用する場合の角度を調整
                    /// TODO: 説明
                    /// </summary>
                    public DegreeMap lookAtVerticalDown { get; set; } = null;

                    /// <summary>
                    /// 頭と目標物の角度差を目ボーンに適用する場合の角度を調整
                    /// TODO: 説明
                    /// </summary>
                    public DegreeMap lookAtVerticalUp { get; set; } = null;
                }
            }
        }
    }
}
