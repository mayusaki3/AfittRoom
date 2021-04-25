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
                /// VRM拡張：一人称設定
                /// </summary>
                /// <remarks>
                /// https://github.com/vrm-c/vrm-specification/blob/master/specification/0.0/schema/vrm.firstperson.schema.json
                /// </remarks>
                public partial class FirstPerson
                {


                    /*

                       "title": "vrm.firstperson",
                        "type": "object",
                        "properties": {
                            "firstPersonBone": {
                                "description": "The bone whose rendering should be turned off in first-person view. Usually Head is specified.",
                                "type": "integer"
                            },
                            "firstPersonBoneOffset": {
                                "description": "The target position of the VR headset in first-person view. It is assumed that an offset from the head bone to the VR headset is added.",
                                "type": "object",
                                "properties": {
                                    "x": {
                                        "type": "number"
                                    },
                                    "y": {
                                        "type": "number"
                                    },
                                    "z": {
                                        "type": "number"
                                    }
                                }
                            },
                            "meshAnnotations": {
                                "description": "Switch display \/ undisplay for each mesh in first-person view or the others.",
                                "type": "array",
                                "items": {
                                    "$ref": "vrm.firstperson.meshannotation.schema.json"
                                }
                            },
                            "lookAtTypeName": {
                                "description": "Eye controller mode.",
                                "type": "string",
                                "enum": ["Bone","BlendShape"]
                            },
                            "lookAtHorizontalInner": {
                                "$ref": "vrm.firstperson.degreemap.schema.json"
                            },
                            "lookAtHorizontalOuter": {
                                "$ref": "vrm.firstperson.degreemap.schema.json"
                            },
                            "lookAtVerticalDown": {
                                "$ref": "vrm.firstperson.degreemap.schema.json"
                            },
                            "lookAtVerticalUp": {
                                "$ref": "vrm.firstperson.degreemap.schema.json"
                            } 

                     */


                    /// <summary>
                    /// 一人称時に描画を切り替えるべきボーン（ボーンリストのインデックス、通常Headを指定）
                    /// </summary>
                    public int? firstPersonBone { get; set; } = null;

                    /// <summary>
                    /// 一人時のヘッドセットの目標位置
                    /// </summary>
                    public Vector3 firstPersonBoneOffset { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// 各メッシュに対して一人称時とそれ以外で表示・非表示を切り替えることができます。 以下の設定があります。
                    /// Auto: firstPersonBoneとその子孫に対するボーンWeightを持つポリゴンを自動で非表示にする^firstPersonAuto
                    /// FirstPersonOnly: 一人称のみ表示
                    /// ThirdPersonOnly: 三人称のみ表示(頭など一人称時に非表示にするメッシュに指定する)
                    /// Both: 特に表示切替をしない
                    /// </summary>
                    public object[] meshAnnotations { get; set; } = null;

                    /// <summary>
                    /// 目線タイプ
                    /// 設定値：Bone       : ボーンにより目線を操作
                    ///         BlendShape : BlendShapeにより目線を操作（BlendShapePreset.LookUp, LookDown, LookLeft, LookRightを使用）
                    /// </summary>
                    public string lookAtTypeName { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
           //         public Lookathorizontalinner lookAtHorizontalInner { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
          //          public Lookathorizontalouter lookAtHorizontalOuter { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
           //         public Lookatverticaldown lookAtVerticalDown { get; set; } = null;

                    /// <summary>
                    /// TODO: 説明
                    /// </summary>
         //           public Lookatverticalup lookAtVerticalUp { get; set; } = null;

                }
            }
        }
    }
}
